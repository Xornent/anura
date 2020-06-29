using System.Collections.Generic;

namespace Anura.Styles
{
    public interface IRuleList : IEnumerable<IRule>
    {
        IRule this[int index] { get; }
        int Length { get; }
    }
}