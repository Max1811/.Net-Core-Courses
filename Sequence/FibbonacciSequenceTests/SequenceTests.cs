using Sequence;
using System;
using System.Collections.Generic;
using Xunit;

namespace FibbonacciSequenceTests
{
    public class SequenceTests
    {
        [Theory]
        [InlineData(0, 10, "0 1 1 2 3 5 8")]
        [InlineData(5, 100, "5 8 13 21 34 55 89")]
        [InlineData(3, 6, "3 5")]
        [InlineData(24, 365, "34 55 89 144 233")]
        [InlineData(50, 1000, "55 89 144 233 377 610 987")]
        [InlineData(50, 10000, "55 89 144 233 377 610 987 1597 2584 4181 6765")]
        [InlineData(50, 1001, "55 89 144 233 377 610 987")] // wrong test (56 is wrong)
        [InlineData(50, 9999, "55 89 144 233 377 610 987 1597 2584 4181 6765")] // wrong test (492 is wrong)
        public void GetSequenceByRangeTestsResultCorrect(int from, int to, string expected)
        {
            ISequence sequence = new FibbonacciSequence(from, to);
            int[] arr = new int[5];

            List<int> expectedSequence = GetListOfFibbonacciNumbers(expected);

            bool actual = true;

            foreach (var item in sequence)
            {
                if (!expectedSequence.Contains(item))
                {
                    actual = false;

                    break;
                }
            }

            Assert.True(actual);
        }

        private List<int> GetListOfFibbonacciNumbers(string expected)
        {
            List<int> sequence = new List<int>();

            string[] numbers = expected.Split(' ');

            for (int i = 0; i < numbers.Length; i++)
            {
                sequence.Add(Convert.ToInt32(numbers[i]));
            }
            return sequence;
        }
    }
}
