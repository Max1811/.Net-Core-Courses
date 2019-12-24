using System.Collections.Generic;

namespace Sequence
{
    public interface ISequence: IEnumerable<int>
    {
        int From { get; }
        int To { get; }
    }
}
