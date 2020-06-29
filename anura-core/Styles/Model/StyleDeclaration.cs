using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Anura.Styles
{
    public sealed class StyleDeclaration : StylesheetNode, IProperties
    {
        readonly Rule _parent;
        readonly StylesheetParser _parser;
        public event Action<string> Changed;

        StyleDeclaration(Rule parent, StylesheetParser parser) {
            _parent = parent;
            _parser = parser;
        }

        internal StyleDeclaration(StylesheetParser parser) : this(null, parser) { }

        internal StyleDeclaration() : this(null, null) { }

        internal StyleDeclaration(Rule parent) : this(parent, parent.Parser) { }

        public void Update(string value) {
            Clear();

            if (!string.IsNullOrEmpty(value)) {
                _parser.AppendDeclarations(this, value);
            }
        }

        public override void ToCss(TextWriter writer, IStyleFormatter formatter) {
            var list = new List<string>();
            var serialized = new List<string>();
            foreach (var declaration in Declarations) {
                var property = declaration.Name;
                if (IsStrictMode) {
                    if (serialized.Contains(property)) {
                        continue;
                    }

                    var shorthands = PropertyFactory.Instance.GetShorthands(property).ToList();
                    if (shorthands.Any()) {
                        var longhands = Declarations.Where(m => !serialized.Contains(m.Name)).ToList();
                        foreach (var shorthand in shorthands.OrderByDescending(m =>
                               PropertyFactory.Instance.GetLonghands(m).Length)) {
                            var rule = PropertyFactory.Instance.CreateShorthand(shorthand);
                            var properties = PropertyFactory.Instance.GetLonghands(shorthand);
                            var currentLonghands = longhands.Where(m => properties.Contains(m.Name)).ToArray();

                            if (currentLonghands.Length == 0) {
                                continue;
                            }

                            var important = currentLonghands.Count(m => m.IsImportant);

                            if (important > 0 && important != currentLonghands.Length) {
                                continue;
                            }

                            if (properties.Length != currentLonghands.Length) {
                                continue;
                            }

                            var value = rule.Stringify(currentLonghands);

                            if (string.IsNullOrEmpty(value)) {
                                continue;
                            }

                            list.Add(CompressedStyleFormatter.Instance.Declaration(shorthand, value, important != 0));

                            foreach (var longhand in currentLonghands) {
                                serialized.Add(longhand.Name);
                                longhands.Remove(longhand);
                            }
                        }
                    }
                    if (serialized.Contains(property)) {
                        continue;
                    }
                    serialized.Add(property);
                }
                list.Add(declaration.ToCss(formatter));
            }
            writer.Write(formatter.Declarations(list));
        }

        public string RemoveProperty(string propertyName) {
            var value = GetPropertyValue(propertyName);
            RemovePropertyByName(propertyName);
            RaiseChanged();

            return value;
        }

        void RemovePropertyByName(string propertyName) {
            foreach (var declaration in Declarations) {
                if (!declaration.Name.Is(propertyName)) {
                    continue;
                }
                RemoveChild(declaration);
                break;
            }

            if (!IsStrictMode || !PropertyFactory.Instance.IsShorthand(propertyName)) {
                return;
            }

            var longhands = PropertyFactory.Instance.GetLonghands(propertyName);
            foreach (var longhand in longhands) {
                RemovePropertyByName(longhand);
            }
        }

        public string GetPropertyPriority(string propertyName) {
            var property = GetProperty(propertyName);
            if (property != null && property.IsImportant) {
                return Keywords.Important;
            }
            if (!IsStrictMode || !PropertyFactory.Instance.IsShorthand(propertyName)) {
                return string.Empty;
            }

            var longhands = PropertyFactory.Instance.GetLonghands(propertyName);

            return longhands.Any(longhand => !GetPropertyPriority(longhand)
               .Isi(Keywords.Important)) ? string.Empty : Keywords.Important;
        }

        public string GetPropertyValue(string propertyName) {
            var property = GetProperty(propertyName);
            if (property != null) {
                return property.Value;
            }

            if (!IsStrictMode || !PropertyFactory.Instance.IsShorthand(propertyName)) {
                return string.Empty;
            }

            var shortHand = PropertyFactory.Instance.CreateShorthand(propertyName);
            var declarations = PropertyFactory.Instance.GetLonghands(propertyName);
            var properties = new List<Property>();

            foreach (var declaration in declarations) {
                property = GetProperty(declaration);
                if (property == null) {
                    return string.Empty;
                }
                properties.Add(property);
            }
            return shortHand.Stringify(properties.ToArray());
        }

        public void SetPropertyValue(string propertyName, string propertyValue) {
            SetProperty(propertyName, propertyValue);
        }

        public void SetPropertyPriority(string propertyName, string priority) {
            if (!string.IsNullOrEmpty(priority) && !priority.Isi(Keywords.Important)) {
                return;
            }

            var important = !string.IsNullOrEmpty(priority);
            var mappings = IsStrictMode && PropertyFactory.Instance.IsShorthand(propertyName) ?
                PropertyFactory.Instance.GetLonghands(propertyName) :
                Enumerable.Repeat(propertyName, 1);

            foreach (var mapping in mappings) {
                var property = GetProperty(mapping);
                if (property != null) {
                    property.IsImportant = important;
                }
            }
        }

        public void SetProperty(string propertyName, string propertyValue, string priority = null) {
            if (!string.IsNullOrEmpty(propertyValue)) {
                if (priority != null && !priority.Isi(Keywords.Important)) {
                    return;
                }

                var value = _parser.ParseValue(propertyValue);
                if (value == null) {
                    return;
                }

                var property = CreateProperty(propertyName);
                if (property == null || !property.TrySetValue(value)) {
                    return;
                }

                property.IsImportant = priority != null;
                SetProperty(property);
                RaiseChanged();
            } else {
                RemoveProperty(propertyName);
            }
        }

        internal Property CreateProperty(string propertyName) {
            var property = GetProperty(propertyName);
            if (property != null) {
                return property;
            }

            property = PropertyFactory.Instance.Create(propertyName);
            if (property != null || IsStrictMode) {
                return property;
            }

            return new UnknownProperty(propertyName);
        }

        internal Property GetProperty(string name) {
            return Declarations.FirstOrDefault(m => m.Name.Isi(name));
        }

        internal void SetProperty(Property property) {
            var shorthand = property as ShorthandProperty;
            if (shorthand != null) {
                SetShorthand(shorthand);
            } else {
                SetLonghand(property);
            }
        }

        internal void SetDeclarations(IEnumerable<Property> decls) {
            ChangeDeclarations(decls, m => false, (o, n) => !o.IsImportant || n.IsImportant);
        }

        internal void UpdateDeclarations(IEnumerable<Property> decls) {
            ChangeDeclarations(decls, m => !m.CanBeInherited, (o, n) => o.IsInherited);
        }

        void ChangeDeclarations(IEnumerable<Property> decls, Predicate<Property> defaultSkip, Func<Property, Property, Boolean> removeExisting) {
            var declarations = new List<Property>();
            foreach (var newdecl in decls) {
                var skip = defaultSkip(newdecl);
                foreach (var olddecl in Declarations) {
                    if (!olddecl.Name.Is(newdecl.Name)) {
                        continue;
                    }

                    if (removeExisting(olddecl, newdecl)) {
                        RemoveChild(olddecl);
                    } else {
                        skip = true;
                    }
                    break;
                }
                if (!skip) {
                    declarations.Add(newdecl);
                }
            }
            foreach (var declaration in declarations) {
                AppendChild(declaration);
            }
        }

        void SetLonghand(Property property) {
            foreach (var declaration in Declarations) {
                if (!declaration.Name.Is(property.Name)) { continue; }
                RemoveChild(declaration);
                break;
            }
            AppendChild(property);
        }

        private void SetShorthand(ShorthandProperty shorthand) {
            var properties = PropertyFactory.Instance.CreateLonghandsFor(shorthand.Name);
            shorthand.Export(properties);

            foreach (var property in properties) {
                SetLonghand(property);
            }
        }

        private void RaiseChanged() {
            Changed?.Invoke(CssText);
        }

        public IEnumerator<IProperty> GetEnumerator() {
            return Declarations.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        public IRule Parent => _parent;
        public string this[int index] => Declarations.GetItemByIndex(index).Name;
        public string this[string name] => GetPropertyValue(name);
        public int Length => Declarations.Count();
        public bool IsStrictMode => /* IsReadOnly ||*/ _parser.Options.IncludeUnknownDeclarations == false;
        //public bool IsReadOnly => _parser == null;
        public IEnumerable<Property> Declarations => Children.OfType<Property>();

        public string CssText {
            get => this.ToCss();
            set { Update(value); RaiseChanged(); }
        }

        public string AlignContent {
            get => GetPropertyValue(PropertyNames.AlignContent);
            set => SetProperty(PropertyNames.AlignContent, value);
        }

        public string AlignItems {
            get => GetPropertyValue(PropertyNames.AlignItems);
            set => SetProperty(PropertyNames.AlignItems, value);
        }

        public string AlignSelf {
            get => GetPropertyValue(PropertyNames.AlignSelf);
            set => SetProperty(PropertyNames.AlignSelf, value);
        }

        public string Accelerator {
            get => GetPropertyValue(PropertyNames.Accelerator);
            set => SetProperty(PropertyNames.Accelerator, value);
        }

        public string AlignmentBaseline {
            get => GetPropertyValue(PropertyNames.AlignBaseline);
            set => SetProperty(PropertyNames.AlignBaseline, value);
        }

        public string Animation {
            get => GetPropertyValue(PropertyNames.Animation);
            set => SetProperty(PropertyNames.Animation, value);
        }

        public string AnimationDelay {
            get => GetPropertyValue(PropertyNames.AnimationDelay);
            set => SetProperty(PropertyNames.AnimationDelay, value);
        }

        public string AnimationDirection {
            get => GetPropertyValue(PropertyNames.AnimationDirection);
            set => SetProperty(PropertyNames.AnimationDirection, value);
        }

        public string AnimationDuration {
            get => GetPropertyValue(PropertyNames.AnimationDuration);
            set => SetProperty(PropertyNames.AnimationDuration, value);
        }

        public string AnimationFillMode {
            get => GetPropertyValue(PropertyNames.AnimationFillMode);
            set => SetProperty(PropertyNames.AnimationFillMode, value);
        }

        public string AnimationIterationCount {
            get => GetPropertyValue(PropertyNames.AnimationIterationCount);
            set => SetProperty(PropertyNames.AnimationIterationCount, value);
        }

        public string AnimationName {
            get => GetPropertyValue(PropertyNames.AnimationName);
            set => SetProperty(PropertyNames.AnimationName, value);
        }

        public string AnimationPlayState {
            get => GetPropertyValue(PropertyNames.AnimationPlayState);
            set => SetProperty(PropertyNames.AnimationPlayState, value);
        }

        public string AnimationTimingFunction {
            get => GetPropertyValue(PropertyNames.AnimationTimingFunction);
            set => SetProperty(PropertyNames.AnimationTimingFunction, value);
        }

        public string BackfaceVisibility {
            get => GetPropertyValue(PropertyNames.BackfaceVisibility);
            set => SetProperty(PropertyNames.BackfaceVisibility, value);
        }

        public string Background {
            get => GetPropertyValue(PropertyNames.Background);
            set => SetProperty(PropertyNames.Background, value);
        }

        public string BackgroundAttachment {
            get => GetPropertyValue(PropertyNames.BackgroundAttachment);
            set => SetProperty(PropertyNames.BackgroundAttachment, value);
        }

        public string BackgroundClip {
            get => GetPropertyValue(PropertyNames.BackgroundClip);
            set => SetProperty(PropertyNames.BackgroundClip, value);
        }

        public string BackgroundColor {
            get => GetPropertyValue(PropertyNames.BackgroundColor);
            set => SetProperty(PropertyNames.BackgroundColor, value);
        }

        public string BackgroundImage {
            get => GetPropertyValue(PropertyNames.BackgroundImage);
            set => SetProperty(PropertyNames.BackgroundImage, value);
        }

        public string BackgroundOrigin {
            get => GetPropertyValue(PropertyNames.BackgroundOrigin);
            set => SetProperty(PropertyNames.BackgroundOrigin, value);
        }

        public string BackgroundPosition {
            get => GetPropertyValue(PropertyNames.BackgroundPosition);
            set => SetProperty(PropertyNames.BackgroundPosition, value);
        }

        public string BackgroundPositionX {
            get => GetPropertyValue(PropertyNames.BackgroundPositionX);
            set => SetProperty(PropertyNames.BackgroundPositionX, value);
        }

        public string BackgroundPositionY {
            get => GetPropertyValue(PropertyNames.BackgroundPositionY);
            set => SetProperty(PropertyNames.BackgroundPositionY, value);
        }

        public string BackgroundRepeat {
            get => GetPropertyValue(PropertyNames.BackgroundRepeat);
            set => SetProperty(PropertyNames.BackgroundRepeat, value);
        }

        public string BackgroundSize {
            get => GetPropertyValue(PropertyNames.BackgroundSize);
            set => SetProperty(PropertyNames.BackgroundSize, value);
        }

        public string BaselineShift {
            get => GetPropertyValue(PropertyNames.BaselineShift);
            set => SetProperty(PropertyNames.BaselineShift, value);
        }

        public string Behavior {
            get => GetPropertyValue(PropertyNames.Behavior);
            set => SetProperty(PropertyNames.Behavior, value);
        }

        public string Bottom {
            get => GetPropertyValue(PropertyNames.Bottom);
            set => SetProperty(PropertyNames.Bottom, value);
        }

        public string Border {
            get => GetPropertyValue(PropertyNames.Border);
            set => SetProperty(PropertyNames.Border, value);
        }

        public string BorderBottom {
            get => GetPropertyValue(PropertyNames.BorderBottom);
            set => SetProperty(PropertyNames.BorderBottom, value);
        }

        public string BorderBottomColor {
            get => GetPropertyValue(PropertyNames.BorderBottomColor);
            set => SetProperty(PropertyNames.BorderBottomColor, value);
        }

        public string BorderBottomLeftRadius {
            get => GetPropertyValue(PropertyNames.BorderBottomLeftRadius);
            set => SetProperty(PropertyNames.BorderBottomLeftRadius, value);
        }

        public string BorderBottomRightRadius {
            get => GetPropertyValue(PropertyNames.BorderBottomRightRadius);
            set => SetProperty(PropertyNames.BorderBottomRightRadius, value);
        }

        public string BorderBottomStyle {
            get => GetPropertyValue(PropertyNames.BorderBottomStyle);
            set => SetProperty(PropertyNames.BorderBottomStyle, value);
        }

        public string BorderBottomWidth {
            get => GetPropertyValue(PropertyNames.BorderBottomWidth);
            set => SetProperty(PropertyNames.BorderBottomWidth, value);
        }

        public string BorderCollapse {
            get => GetPropertyValue(PropertyNames.BorderCollapse);
            set => SetProperty(PropertyNames.BorderCollapse, value);
        }

        public string BorderColor {
            get => GetPropertyValue(PropertyNames.BorderColor);
            set => SetProperty(PropertyNames.BorderColor, value);
        }

        public string BorderImage {
            get => GetPropertyValue(PropertyNames.BorderImage);
            set => SetProperty(PropertyNames.BorderImage, value);
        }

        public string BorderImageOutset {
            get => GetPropertyValue(PropertyNames.BorderImageOutset);
            set => SetProperty(PropertyNames.BorderImageOutset, value);
        }

        public string BorderImageRepeat {
            get => GetPropertyValue(PropertyNames.BorderImageRepeat);
            set => SetProperty(PropertyNames.BorderImageRepeat, value);
        }

        public string BorderImageSlice {
            get => GetPropertyValue(PropertyNames.BorderImageSlice);
            set => SetProperty(PropertyNames.BorderImageSlice, value);
        }

        public string BorderImageSource {
            get => GetPropertyValue(PropertyNames.BorderImageSource);
            set => SetProperty(PropertyNames.BorderImageSource, value);
        }

        public string BorderImageWidth {
            get => GetPropertyValue(PropertyNames.BorderImageWidth);
            set => SetProperty(PropertyNames.BorderImageWidth, value);
        }

        public string BorderLeft {
            get => GetPropertyValue(PropertyNames.BorderLeft);
            set => SetProperty(PropertyNames.BorderLeft, value);
        }

        public string BorderLeftColor {
            get => GetPropertyValue(PropertyNames.BorderLeftColor);
            set => SetProperty(PropertyNames.BorderLeftColor, value);
        }

        public string BorderLeftStyle {
            get => GetPropertyValue(PropertyNames.BorderLeftStyle);
            set => SetProperty(PropertyNames.BorderLeftStyle, value);
        }

        public string BorderLeftWidth {
            get => GetPropertyValue(PropertyNames.BorderLeftWidth);
            set => SetProperty(PropertyNames.BorderLeftWidth, value);
        }

        public string BorderRadius {
            get => GetPropertyValue(PropertyNames.BorderRadius);
            set => SetProperty(PropertyNames.BorderRadius, value);
        }

        public string BorderRight {
            get => GetPropertyValue(PropertyNames.BorderRight);
            set => SetProperty(PropertyNames.BorderRight, value);
        }

        public string BorderRightColor {
            get => GetPropertyValue(PropertyNames.BorderRightColor);
            set => SetProperty(PropertyNames.BorderRightColor, value);
        }

        public string BorderRightStyle {
            get => GetPropertyValue(PropertyNames.BorderRightStyle);
            set => SetProperty(PropertyNames.BorderRightStyle, value);
        }

        public string BorderRightWidth {
            get => GetPropertyValue(PropertyNames.BorderRightWidth);
            set => SetProperty(PropertyNames.BorderRightWidth, value);
        }

        public string BorderSpacing {
            get => GetPropertyValue(PropertyNames.BorderSpacing);
            set => SetProperty(PropertyNames.BorderSpacing, value);
        }

        public string BorderStyle {
            get => GetPropertyValue(PropertyNames.BorderStyle);
            set => SetProperty(PropertyNames.BorderStyle, value);
        }

        public string BorderTop {
            get => GetPropertyValue(PropertyNames.BorderTop);
            set => SetProperty(PropertyNames.BorderTop, value);
        }

        public string BorderTopColor {
            get => GetPropertyValue(PropertyNames.BorderTopColor);
            set => SetProperty(PropertyNames.BorderTopColor, value);
        }

        public string BorderTopLeftRadius {
            get => GetPropertyValue(PropertyNames.BorderTopLeftRadius);
            set => SetProperty(PropertyNames.BorderTopLeftRadius, value);
        }

        public string BorderTopRightRadius {
            get => GetPropertyValue(PropertyNames.BorderTopRightRadius);
            set => SetProperty(PropertyNames.BorderTopRightRadius, value);
        }

        public string BorderTopStyle {
            get => GetPropertyValue(PropertyNames.BorderTopStyle);
            set => SetProperty(PropertyNames.BorderTopStyle, value);
        }

        public string BorderTopWidth {
            get => GetPropertyValue(PropertyNames.BorderTopWidth);
            set => SetProperty(PropertyNames.BorderTopWidth, value);
        }

        public string BorderWidth {
            get => GetPropertyValue(PropertyNames.BorderWidth);
            set => SetProperty(PropertyNames.BorderWidth, value);
        }

        public string BoxShadow {
            get => GetPropertyValue(PropertyNames.BoxShadow);
            set => SetProperty(PropertyNames.BoxShadow, value);
        }

        public string BoxSizing {
            get => GetPropertyValue(PropertyNames.BoxSizing);
            set => SetProperty(PropertyNames.BoxSizing, value);
        }

        public string BreakAfter {
            get => GetPropertyValue(PropertyNames.BreakAfter);
            set => SetProperty(PropertyNames.BreakAfter, value);
        }

        public string BreakBefore {
            get => GetPropertyValue(PropertyNames.BreakBefore);
            set => SetProperty(PropertyNames.BreakBefore, value);
        }

        public string BreakInside {
            get => GetPropertyValue(PropertyNames.BreakInside);
            set => SetProperty(PropertyNames.BreakInside, value);
        }

        public string CaptionSide {
            get => GetPropertyValue(PropertyNames.CaptionSide);
            set => SetProperty(PropertyNames.CaptionSide, value);
        }

        public new string Clear {
            get => GetPropertyValue(PropertyNames.Clear);
            set => SetProperty(PropertyNames.Clear, value);
        }

        public string Clip {
            get => GetPropertyValue(PropertyNames.Clip);
            set => SetProperty(PropertyNames.Clip, value);
        }

        public string ClipBottom {
            get => GetPropertyValue(PropertyNames.ClipBottom);
            set => SetProperty(PropertyNames.ClipBottom, value);
        }

        public string ClipLeft {
            get => GetPropertyValue(PropertyNames.ClipLeft);
            set => SetProperty(PropertyNames.ClipLeft, value);
        }

        public string ClipPath {
            get => GetPropertyValue(PropertyNames.ClipPath);
            set => SetProperty(PropertyNames.ClipPath, value);
        }

        public string ClipRight {
            get => GetPropertyValue(PropertyNames.ClipRight);
            set => SetProperty(PropertyNames.ClipRight, value);
        }

        public string ClipRule {
            get => GetPropertyValue(PropertyNames.ClipRule);
            set => SetProperty(PropertyNames.ClipRule, value);
        }

        public string ClipTop {
            get => GetPropertyValue(PropertyNames.ClipTop);
            set => SetProperty(PropertyNames.ClipTop, value);
        }

        public string Color {
            get => GetPropertyValue(PropertyNames.Color);
            set => SetProperty(PropertyNames.Color, value);
        }

        public string ColorInterpolationFilters {
            get => GetPropertyValue(PropertyNames.ColorInterpolationFilters);
            set => SetProperty(PropertyNames.ColorInterpolationFilters, value);
        }

        public string ColumnCount {
            get => GetPropertyValue(PropertyNames.ColumnCount);
            set => SetProperty(PropertyNames.ColumnCount, value);
        }

        public string ColumnFill {
            get => GetPropertyValue(PropertyNames.ColumnFill);
            set => SetProperty(PropertyNames.ColumnFill, value);
        }

        public string ColumnGap {
            get => GetPropertyValue(PropertyNames.ColumnGap);
            set => SetProperty(PropertyNames.ColumnGap, value);
        }

        public string ColumnRule {
            get => GetPropertyValue(PropertyNames.ColumnRule);
            set => SetProperty(PropertyNames.ColumnRule, value);
        }

        public string ColumnRuleColor {
            get => GetPropertyValue(PropertyNames.ColumnRuleColor);
            set => SetProperty(PropertyNames.ColumnRuleColor, value);
        }

        public string ColumnRuleStyle {
            get => GetPropertyValue(PropertyNames.ColumnRuleStyle);
            set => SetProperty(PropertyNames.ColumnRuleStyle, value);
        }

        public string ColumnRuleWidth {
            get => GetPropertyValue(PropertyNames.ColumnRuleWidth);
            set => SetProperty(PropertyNames.ColumnRuleWidth, value);
        }

        public string Columns {
            get => GetPropertyValue(PropertyNames.Columns);
            set => SetProperty(PropertyNames.Columns, value);
        }

        public string ColumnSpan {
            get => GetPropertyValue(PropertyNames.ColumnSpan);
            set => SetProperty(PropertyNames.ColumnSpan, value);
        }

        public string ColumnWidth {
            get => GetPropertyValue(PropertyNames.ColumnWidth);
            set => SetProperty(PropertyNames.ColumnWidth, value);
        }

        public string Content {
            get => GetPropertyValue(PropertyNames.Content);
            set => SetProperty(PropertyNames.Content, value);
        }

        public string CounterIncrement {
            get => GetPropertyValue(PropertyNames.CounterIncrement);
            set => SetProperty(PropertyNames.CounterIncrement, value);
        }

        public string CounterReset {
            get => GetPropertyValue(PropertyNames.CounterReset);
            set => SetProperty(PropertyNames.CounterReset, value);
        }

        public string Float {
            get => GetPropertyValue(PropertyNames.Float);
            set => SetProperty(PropertyNames.Float, value);
        }

        public string Cursor {
            get => GetPropertyValue(PropertyNames.Cursor);
            set => SetProperty(PropertyNames.Cursor, value);
        }

        public string Direction {
            get => GetPropertyValue(PropertyNames.Direction);
            set => SetProperty(PropertyNames.Direction, value);
        }

        public string Display {
            get => GetPropertyValue(PropertyNames.Display);
            set => SetProperty(PropertyNames.Display, value);
        }

        public string DominantBaseline {
            get => GetPropertyValue(PropertyNames.DominantBaseline);
            set => SetProperty(PropertyNames.DominantBaseline, value);
        }

        public string EmptyCells {
            get => GetPropertyValue(PropertyNames.EmptyCells);
            set => SetProperty(PropertyNames.EmptyCells, value);
        }

        public string EnableBackground {
            get => GetPropertyValue(PropertyNames.EnableBackground);
            set => SetProperty(PropertyNames.EnableBackground, value);
        }

        public string Fill {
            get => GetPropertyValue(PropertyNames.Fill);
            set => SetProperty(PropertyNames.Fill, value);
        }

        public string FillOpacity {
            get => GetPropertyValue(PropertyNames.FillOpacity);
            set => SetProperty(PropertyNames.FillOpacity, value);
        }

        public string FillRule {
            get => GetPropertyValue(PropertyNames.FillRule);
            set => SetProperty(PropertyNames.FillRule, value);
        }

        public string Filter {
            get => GetPropertyValue(PropertyNames.Filter);
            set => SetProperty(PropertyNames.Filter, value);
        }

        public string Flex {
            get => GetPropertyValue(PropertyNames.Flex);
            set => SetProperty(PropertyNames.Flex, value);
        }

        public string FlexBasis {
            get => GetPropertyValue(PropertyNames.FlexBasis);
            set => SetProperty(PropertyNames.FlexBasis, value);
        }

        public string FlexDirection {
            get => GetPropertyValue(PropertyNames.FlexDirection);
            set => SetProperty(PropertyNames.FlexDirection, value);
        }

        public string FlexFlow {
            get => GetPropertyValue(PropertyNames.FlexFlow);
            set => SetProperty(PropertyNames.FlexFlow, value);
        }

        public string FlexGrow {
            get => GetPropertyValue(PropertyNames.FlexGrow);
            set => SetProperty(PropertyNames.FlexGrow, value);
        }

        public string FlexShrink {
            get => GetPropertyValue(PropertyNames.FlexShrink);
            set => SetProperty(PropertyNames.FlexShrink, value);
        }

        public string FlexWrap {
            get => GetPropertyValue(PropertyNames.FlexWrap);
            set => SetProperty(PropertyNames.FlexWrap, value);
        }

        public string Font {
            get => GetPropertyValue(PropertyNames.Font);
            set => SetProperty(PropertyNames.Font, value);
        }

        public string FontFamily {
            get => GetPropertyValue(PropertyNames.FontFamily);
            set => SetProperty(PropertyNames.FontFamily, value);
        }

        public string FontFeatureSettings {
            get => GetPropertyValue(PropertyNames.FontFeatureSettings);
            set => SetProperty(PropertyNames.FontFeatureSettings, value);
        }

        public string FontSize {
            get => GetPropertyValue(PropertyNames.FontSize);
            set => SetProperty(PropertyNames.FontSize, value);
        }

        public string FontSizeAdjust {
            get => GetPropertyValue(PropertyNames.FontSizeAdjust);
            set => SetProperty(PropertyNames.FontSizeAdjust, value);
        }

        public string FontStretch {
            get => GetPropertyValue(PropertyNames.FontStretch);
            set => SetProperty(PropertyNames.FontStretch, value);
        }

        public string FontStyle {
            get => GetPropertyValue(PropertyNames.FontStyle);
            set => SetProperty(PropertyNames.FontStyle, value);
        }

        public string FontVariant {
            get => GetPropertyValue(PropertyNames.FontVariant);
            set => SetProperty(PropertyNames.FontVariant, value);
        }

        public string FontWeight {
            get => GetPropertyValue(PropertyNames.FontWeight);
            set => SetProperty(PropertyNames.FontWeight, value);
        }

        public string GlyphOrientationHorizontal {
            get => GetPropertyValue(PropertyNames.GlyphOrientationHorizontal);
            set => SetProperty(PropertyNames.GlyphOrientationHorizontal, value);
        }

        public string GlyphOrientationVertical {
            get => GetPropertyValue(PropertyNames.GlyphOrientationVertical);
            set => SetProperty(PropertyNames.GlyphOrientationVertical, value);
        }

        public string Height {
            get => GetPropertyValue(PropertyNames.Height);
            set => SetProperty(PropertyNames.Height, value);
        }

        public string ImeMode {
            get => GetPropertyValue(PropertyNames.ImeMode);
            set => SetProperty(PropertyNames.ImeMode, value);
        }

        public string JustifyContent {
            get => GetPropertyValue(PropertyNames.JustifyContent);
            set => SetProperty(PropertyNames.JustifyContent, value);
        }

        public string LayoutGrid {
            get => GetPropertyValue(PropertyNames.LayoutGrid);
            set => SetProperty(PropertyNames.LayoutGrid, value);
        }

        public string LayoutGridChar {
            get => GetPropertyValue(PropertyNames.LayoutGridChar);
            set => SetProperty(PropertyNames.LayoutGridChar, value);
        }

        public string LayoutGridLine {
            get => GetPropertyValue(PropertyNames.LayoutGridLine);
            set => SetProperty(PropertyNames.LayoutGridLine, value);
        }

        public string LayoutGridMode {
            get => GetPropertyValue(PropertyNames.LayoutGridMode);
            set => SetProperty(PropertyNames.LayoutGridMode, value);
        }

        public string LayoutGridType {
            get => GetPropertyValue(PropertyNames.LayoutGridType);
            set => SetProperty(PropertyNames.LayoutGridType, value);
        }

        public string Left {
            get => GetPropertyValue(PropertyNames.Left);
            set => SetProperty(PropertyNames.Left, value);
        }

        public string LetterSpacing {
            get => GetPropertyValue(PropertyNames.LetterSpacing);
            set => SetProperty(PropertyNames.LetterSpacing, value);
        }

        public string LineHeight {
            get => GetPropertyValue(PropertyNames.LineHeight);
            set => SetProperty(PropertyNames.LineHeight, value);
        }

        public string ListStyle {
            get => GetPropertyValue(PropertyNames.ListStyle);
            set => SetProperty(PropertyNames.ListStyle, value);
        }

        public string ListStyleImage {
            get => GetPropertyValue(PropertyNames.ListStyleImage);
            set => SetProperty(PropertyNames.ListStyleImage, value);
        }

        public string ListStylePosition {
            get => GetPropertyValue(PropertyNames.ListStylePosition);
            set => SetProperty(PropertyNames.ListStylePosition, value);
        }

        public string ListStyleType {
            get => GetPropertyValue(PropertyNames.ListStyleType);
            set => SetProperty(PropertyNames.ListStyleType, value);
        }

        public string Margin {
            get => GetPropertyValue(PropertyNames.Margin);
            set => SetProperty(PropertyNames.Margin, value);
        }

        public string MarginBottom {
            get => GetPropertyValue(PropertyNames.MarginBottom);
            set => SetProperty(PropertyNames.MarginBottom, value);
        }

        public string MarginLeft {
            get => GetPropertyValue(PropertyNames.MarginLeft);
            set => SetProperty(PropertyNames.MarginLeft, value);
        }

        public string MarginRight {
            get => GetPropertyValue(PropertyNames.MarginRight);
            set => SetProperty(PropertyNames.MarginRight, value);
        }

        public string MarginTop {
            get => GetPropertyValue(PropertyNames.MarginTop);
            set => SetProperty(PropertyNames.MarginTop, value);
        }

        public string Marker {
            get => GetPropertyValue(PropertyNames.Marker);
            set => SetProperty(PropertyNames.Marker, value);
        }

        public string MarkerEnd {
            get => GetPropertyValue(PropertyNames.MarkerEnd);
            set => SetProperty(PropertyNames.MarkerEnd, value);
        }

        public string MarkerMid {
            get => GetPropertyValue(PropertyNames.MarkerMid);
            set => SetProperty(PropertyNames.MarkerMid, value);
        }

        public string MarkerStart {
            get => GetPropertyValue(PropertyNames.MarkerStart);
            set => SetProperty(PropertyNames.MarkerStart, value);
        }

        public string Mask {
            get => GetPropertyValue(PropertyNames.Mask);
            set => SetProperty(PropertyNames.Mask, value);
        }

        public string MaxHeight {
            get => GetPropertyValue(PropertyNames.MaxHeight);
            set => SetProperty(PropertyNames.MaxHeight, value);
        }

        public string MaxWidth {
            get => GetPropertyValue(PropertyNames.MaxWidth);
            set => SetProperty(PropertyNames.MaxWidth, value);
        }

        public string MinHeight {
            get => GetPropertyValue(PropertyNames.MinHeight);
            set => SetProperty(PropertyNames.MinHeight, value);
        }

        public string MinWidth {
            get => GetPropertyValue(PropertyNames.MinWidth);
            set => SetProperty(PropertyNames.MinWidth, value);
        }

        public string Opacity {
            get => GetPropertyValue(PropertyNames.Opacity);
            set => SetProperty(PropertyNames.Opacity, value);
        }

        public string Order {
            get => GetPropertyValue(PropertyNames.Order);
            set => SetProperty(PropertyNames.Order, value);
        }

        public string Orphans {
            get => GetPropertyValue(PropertyNames.Orphans);
            set => SetProperty(PropertyNames.Orphans, value);
        }

        public string Outline {
            get => GetPropertyValue(PropertyNames.Outline);
            set => SetProperty(PropertyNames.Outline, value);
        }

        public string OutlineColor {
            get => GetPropertyValue(PropertyNames.OutlineColor);
            set => SetProperty(PropertyNames.OutlineColor, value);
        }

        public string OutlineStyle {
            get => GetPropertyValue(PropertyNames.OutlineStyle);
            set => SetProperty(PropertyNames.OutlineStyle, value);
        }

        public string OutlineWidth {
            get => GetPropertyValue(PropertyNames.OutlineWidth);
            set => SetProperty(PropertyNames.OutlineWidth, value);
        }

        public string Overflow {
            get => GetPropertyValue(PropertyNames.Overflow);
            set => SetProperty(PropertyNames.Overflow, value);
        }

        public string OverflowX {
            get => GetPropertyValue(PropertyNames.OverflowX);
            set => SetProperty(PropertyNames.OverflowX, value);
        }

        public string OverflowY {
            get => GetPropertyValue(PropertyNames.OverflowY);
            set => SetProperty(PropertyNames.OverflowY, value);
        }

        public string OverflowWrap {
            get => GetPropertyValue(PropertyNames.WordWrap);
            set => SetProperty(PropertyNames.WordWrap, value);
        }

        public string Padding {
            get => GetPropertyValue(PropertyNames.Padding);
            set => SetProperty(PropertyNames.Padding, value);
        }

        public string PaddingBottom {
            get => GetPropertyValue(PropertyNames.PaddingBottom);
            set => SetProperty(PropertyNames.PaddingBottom, value);
        }

        public string PaddingLeft {
            get => GetPropertyValue(PropertyNames.PaddingLeft);
            set => SetProperty(PropertyNames.PaddingLeft, value);
        }

        public string PaddingRight {
            get => GetPropertyValue(PropertyNames.PaddingRight);
            set => SetProperty(PropertyNames.PaddingRight, value);
        }

        public string PaddingTop {
            get => GetPropertyValue(PropertyNames.PaddingTop);
            set => SetProperty(PropertyNames.PaddingTop, value);
        }

        public string PageBreakAfter {
            get => GetPropertyValue(PropertyNames.PageBreakAfter);
            set => SetProperty(PropertyNames.PageBreakAfter, value);
        }

        public string PageBreakBefore {
            get => GetPropertyValue(PropertyNames.PageBreakBefore);
            set => SetProperty(PropertyNames.PageBreakBefore, value);
        }

        public string PageBreakInside {
            get => GetPropertyValue(PropertyNames.PageBreakInside);
            set => SetProperty(PropertyNames.PageBreakInside, value);
        }

        public string Perspective {
            get => GetPropertyValue(PropertyNames.Perspective);
            set => SetProperty(PropertyNames.Perspective, value);
        }

        public string PerspectiveOrigin {
            get => GetPropertyValue(PropertyNames.PerspectiveOrigin);
            set => SetProperty(PropertyNames.PerspectiveOrigin, value);
        }

        public string PointerEvents {
            get => GetPropertyValue(PropertyNames.PointerEvents);
            set => SetProperty(PropertyNames.PointerEvents, value);
        }

        public string Quotes {
            get => GetPropertyValue(PropertyNames.Quotes);
            set => SetProperty(PropertyNames.Quotes, value);
        }

        public string Position {
            get => GetPropertyValue(PropertyNames.Position);
            set => SetProperty(PropertyNames.Position, value);
        }

        public string Right {
            get => GetPropertyValue(PropertyNames.Right);
            set => SetProperty(PropertyNames.Right, value);
        }

        public string RubyAlign {
            get => GetPropertyValue(PropertyNames.RubyAlign);
            set => SetProperty(PropertyNames.RubyAlign, value);
        }

        public string RubyOverhang {
            get => GetPropertyValue(PropertyNames.RubyOverhang);
            set => SetProperty(PropertyNames.RubyOverhang, value);
        }

        public string RubyPosition {
            get => GetPropertyValue(PropertyNames.RubyPosition);
            set => SetProperty(PropertyNames.RubyPosition, value);
        }

        public string Scrollbar3DLightColor {
            get => GetPropertyValue(PropertyNames.Scrollbar3dLightColor);
            set => SetProperty(PropertyNames.Scrollbar3dLightColor, value);
        }

        public string ScrollbarArrowColor {
            get => GetPropertyValue(PropertyNames.ScrollbarArrowColor);
            set => SetProperty(PropertyNames.ScrollbarArrowColor, value);
        }

        public string ScrollbarDarkShadowColor {
            get => GetPropertyValue(PropertyNames.ScrollbarDarkShadowColor);
            set => SetProperty(PropertyNames.ScrollbarDarkShadowColor, value);
        }

        public string ScrollbarFaceColor {
            get => GetPropertyValue(PropertyNames.ScrollbarFaceColor);
            set => SetProperty(PropertyNames.ScrollbarFaceColor, value);
        }

        public string ScrollbarHighlightColor {
            get => GetPropertyValue(PropertyNames.ScrollbarHighlightColor);
            set => SetProperty(PropertyNames.ScrollbarHighlightColor, value);
        }

        public string ScrollbarShadowColor {
            get => GetPropertyValue(PropertyNames.ScrollbarShadowColor);
            set => SetProperty(PropertyNames.ScrollbarShadowColor, value);
        }

        public string ScrollbarTrackColor {
            get => GetPropertyValue(PropertyNames.ScrollbarTrackColor);
            set => SetProperty(PropertyNames.ScrollbarTrackColor, value);
        }

        public string Stroke {
            get => GetPropertyValue(PropertyNames.Stroke);
            set => SetProperty(PropertyNames.Stroke, value);
        }

        public string StrokeDasharray {
            get => GetPropertyValue(PropertyNames.StrokeDasharray);
            set => SetProperty(PropertyNames.StrokeDasharray, value);
        }

        public string StrokeDashoffset {
            get => GetPropertyValue(PropertyNames.StrokeDashoffset);
            set => SetProperty(PropertyNames.StrokeDashoffset, value);
        }

        public string StrokeLinecap {
            get => GetPropertyValue(PropertyNames.StrokeLinecap);
            set => SetProperty(PropertyNames.StrokeLinecap, value);
        }

        public string StrokeLinejoin {
            get => GetPropertyValue(PropertyNames.StrokeLinejoin);
            set => SetProperty(PropertyNames.StrokeLinejoin, value);
        }

        public string StrokeMiterlimit {
            get => GetPropertyValue(PropertyNames.StrokeMiterlimit);
            set => SetProperty(PropertyNames.StrokeMiterlimit, value);
        }

        public string StrokeOpacity {
            get => GetPropertyValue(PropertyNames.StrokeOpacity);
            set => SetProperty(PropertyNames.StrokeOpacity, value);
        }

        public string StrokeWidth {
            get => GetPropertyValue(PropertyNames.StrokeWidth);
            set => SetProperty(PropertyNames.StrokeWidth, value);
        }

        public string TableLayout {
            get => GetPropertyValue(PropertyNames.TableLayout);
            set => SetProperty(PropertyNames.TableLayout, value);
        }

        public string TextAlign {
            get => GetPropertyValue(PropertyNames.TextAlign);
            set => SetProperty(PropertyNames.TextAlign, value);
        }

        public string TextAlignLast {
            get => GetPropertyValue(PropertyNames.TextAlignLast);
            set => SetProperty(PropertyNames.TextAlignLast, value);
        }

        public string TextAnchor {
            get => GetPropertyValue(PropertyNames.TextAnchor);
            set => SetProperty(PropertyNames.TextAnchor, value);
        }

        public string TextAutospace {
            get => GetPropertyValue(PropertyNames.TextAutospace);
            set => SetProperty(PropertyNames.TextAutospace, value);
        }

        public string TextDecoration {
            get => GetPropertyValue(PropertyNames.TextDecoration);
            set => SetProperty(PropertyNames.TextDecoration, value);
        }

        public string TextIndent {
            get => GetPropertyValue(PropertyNames.TextIndent);
            set => SetProperty(PropertyNames.TextIndent, value);
        }

        public string TextJustify {
            get => GetPropertyValue(PropertyNames.TextJustify);
            set => SetProperty(PropertyNames.TextJustify, value);
        }

        public string TextOverflow {
            get => GetPropertyValue(PropertyNames.TextOverflow);
            set => SetProperty(PropertyNames.TextOverflow, value);
        }

        public string TextShadow {
            get => GetPropertyValue(PropertyNames.TextShadow);
            set => SetProperty(PropertyNames.TextShadow, value);
        }

        public string TextTransform {
            get => GetPropertyValue(PropertyNames.TextTransform);
            set => SetProperty(PropertyNames.TextTransform, value);
        }

        public string TextUnderlinePosition {
            get => GetPropertyValue(PropertyNames.TextUnderlinePosition);
            set => SetProperty(PropertyNames.TextUnderlinePosition, value);
        }

        public string Top {
            get => GetPropertyValue(PropertyNames.Top);
            set => SetProperty(PropertyNames.Top, value);
        }

        public string Transform {
            get => GetPropertyValue(PropertyNames.Transform);
            set => SetProperty(PropertyNames.Transform, value);
        }

        public string TransformOrigin {
            get => GetPropertyValue(PropertyNames.TransformOrigin);
            set => SetProperty(PropertyNames.TransformOrigin, value);
        }

        public string TransformStyle {
            get => GetPropertyValue(PropertyNames.TransformStyle);
            set => SetProperty(PropertyNames.TransformStyle, value);
        }

        public string Transition {
            get => GetPropertyValue(PropertyNames.Transition);
            set => SetProperty(PropertyNames.Transition, value);
        }

        public string TransitionDelay {
            get => GetPropertyValue(PropertyNames.TransitionDelay);
            set => SetProperty(PropertyNames.TransitionDelay, value);
        }

        public string TransitionDuration {
            get => GetPropertyValue(PropertyNames.TransitionDuration);
            set => SetProperty(PropertyNames.TransitionDuration, value);
        }

        public string TransitionProperty {
            get => GetPropertyValue(PropertyNames.TransitionProperty);
            set => SetProperty(PropertyNames.TransitionProperty, value);
        }

        public string TransitionTimingFunction {
            get => GetPropertyValue(PropertyNames.TransitionTimingFunction);
            set => SetProperty(PropertyNames.TransitionTimingFunction, value);
        }

        public string UnicodeBidirectional {
            get => GetPropertyValue(PropertyNames.UnicodeBidirectional);
            set => SetProperty(PropertyNames.UnicodeBidirectional, value);
        }

        public string VerticalAlign {
            get => GetPropertyValue(PropertyNames.VerticalAlign);
            set => SetProperty(PropertyNames.VerticalAlign, value);
        }

        public string Visibility {
            get => GetPropertyValue(PropertyNames.Visibility);
            set => SetProperty(PropertyNames.Visibility, value);
        }

        public string WhiteSpace {
            get => GetPropertyValue(PropertyNames.WhiteSpace);
            set => SetProperty(PropertyNames.WhiteSpace, value);
        }

        public string Widows {
            get => GetPropertyValue(PropertyNames.Widows);
            set => SetProperty(PropertyNames.Widows, value);
        }

        public string Width {
            get => GetPropertyValue(PropertyNames.Width);
            set => SetProperty(PropertyNames.Width, value);
        }

        public string WordBreak {
            get => GetPropertyValue(PropertyNames.WordBreak);
            set => SetProperty(PropertyNames.WordBreak, value);
        }

        public string WordSpacing {
            get => GetPropertyValue(PropertyNames.WordSpacing);
            set => SetProperty(PropertyNames.WordSpacing, value);
        }

        public string WritingMode {
            get => GetPropertyValue(PropertyNames.WritingMode);
            set => SetProperty(PropertyNames.WritingMode, value);
        }

        public string ZIndex {
            get => GetPropertyValue(PropertyNames.ZIndex);
            set => SetProperty(PropertyNames.ZIndex, value);
        }

        public string Zoom {
            get => GetPropertyValue(PropertyNames.Zoom);
            set => SetProperty(PropertyNames.Zoom, value);
        }

    }
}