using System.Collections.Generic;
using Anura.Typography.OpenFont;

namespace Anura.Typography.Contours {
    public class GlyphContourBuilder : IGlyphTranslator {
        private List<GlyphContour> _contours;

        private float _curX;

        private float _curY;

        private float _latestMoveToX;

        private float _latestMoveToY;

        private GlyphContour _currentCnt;

        private GlyphPart _latestPart;

        public List<GlyphContour> GetContours () {
            return _contours;
        }

        public void MoveTo (float x0, float y0) {
            _latestMoveToX = (_curX = x0);
            _latestMoveToY = (_curY = y0);
            _latestPart = null;
        }

        public void LineTo (float x1, float y1) {
            if (_latestPart != null) {
                _currentCnt.AddPart (_latestPart = new GlyphLine (_latestPart, x1, y1));
            } else {
                _currentCnt.AddPart (_latestPart = new GlyphLine (_curX, _curY, x1, y1));
            }
            _curX = x1;
            _curY = y1;
        }

        public void Curve3 (float x1, float y1, float x2, float y2) {
            if (_latestPart != null) {
                _currentCnt.AddPart (_latestPart = new GlyphCurve3 (_latestPart, x1, y1, x2, y2));
            } else {
                _currentCnt.AddPart (new GlyphCurve3 (_curX, _curY, x1, y1, x2, y2));
            }
            _curX = x2;
            _curY = y2;
        }

        public void Curve4 (float x1, float y1, float x2, float y2, float x3, float y3) {
            if (_latestPart != null) {
                _currentCnt.AddPart (_latestPart = new GlyphCurve4 (_latestPart, x1, y1, x2, y2, x3, y3));
            } else {
                _currentCnt.AddPart (_latestPart = new GlyphCurve4 (_curX, _curY, x1, y1, x2, y2, x3, y3));
            }
            _curX = x3;
            _curY = y3;
        }

        public void CloseContour () {
            if (_curX != _latestMoveToX || _curY != _latestMoveToY) {
                if (_latestPart != null) {
                    _currentCnt.AddPart (_latestPart = new GlyphLine (_latestPart, _latestMoveToX, _latestMoveToY));
                } else {
                    _currentCnt.AddPart (_latestPart = new GlyphLine (_curX, _curY, _latestMoveToX, _latestMoveToY));
                }
            }
            _curX = _latestMoveToX;
            _curY = _latestMoveToY;
            if (_currentCnt != null && _currentCnt.parts.Count > 0) {
                _contours.Add (_currentCnt);
                _currentCnt = null;
            }
            _currentCnt = new GlyphContour ();
        }

        public void BeginRead (int contourCount) {
            _contours = new List<GlyphContour> ();
            _latestPart = null;
            _latestMoveToX = (_curX = (_latestMoveToY = (_curY = 0f)));
            _currentCnt = new GlyphContour ();
        }

        public void EndRead () { }
    }
}