using Sequence;
using Xunit;

namespace FibbonacciSequenceTests
{
    public class SequenceTests
    {
        [Theory]
        [InlineData(0, 10)]
        public void GetSequenceByRangeTestsResultTrue(int from, int to)
        {
            ISequence sequence = new FibbonacciSequence(from, to);

            
        }

        //private int GetSequenceElement(int from, int to)
        //{
        //    int previous = 0;
        //    int current = 1;
        //}
    }
}
