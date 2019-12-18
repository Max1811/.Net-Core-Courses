using System.Collections.Generic;

namespace SequenceTask.SequenceOfNumbers
{
    public class Sequence
    {
        public IEnumerable<int> NumbersSequence { get;  }
        public Sequence(IEnumerable<int> sequence)
        {
            NumbersSequence = sequence;
        }

    }
}
