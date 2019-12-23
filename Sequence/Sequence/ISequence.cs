using System;
using System.Collections.Generic;
using System.Text;

namespace Sequence
{
    public interface ISequence: IEnumerable<int>
    {
        int From { get; }
        int To { get; }
    }
}
