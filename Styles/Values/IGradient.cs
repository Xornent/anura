using System.Collections.Generic;

namespace Anura.Styles {
    public interface IGradient : IImageSource {
        IEnumerable<GradientStop> Stops { get; }
        bool IsRepeating { get; }
    }
}