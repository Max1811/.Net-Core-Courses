using Sequence;
using Xunit;

namespace FibbonacciSequenceTests
{
    public class ValidatorTests
    {
        [Theory]
        [InlineData(1, 4)]
        [InlineData(23, 35)]
        [InlineData(12, 343443)]
        [InlineData(2, 3)]
        [InlineData(223, 332)]
        [InlineData(3333333, 3333334)]
        public void ValidateFibbonacciSequenceRangeValuesResultTrue(int from, int to)
        {
            ISequence sequence = new FibbonacciSequence(from, to);

            SequenceValidator validator = new SequenceValidator();

            Assert.True(validator.Validate(sequence).IsValid);
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(0, -1)]
        [InlineData(0, 0)]
        [InlineData(-2, -2)]
        [InlineData(4545, -332)]
        [InlineData(-2323, -994)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        public void ValidateFibbonacciSequenceRangeValuesResultFalse(int from, int to)
        {
            ISequence sequence = new FibbonacciSequence(from, to);

            SequenceValidator validator = new SequenceValidator();

            Assert.False(validator.Validate(sequence).IsValid);
        }

        [Theory]
        [InlineData(1, 4)]
        [InlineData(23, 35)]
        [InlineData(12, 343443)]
        [InlineData(2, 62)]
        [InlineData(223, 332)]
        [InlineData(3333333, 3333334)]
        public void ValidateSquareSequenceRangeValuesResultTrue(int from, int to)
        {
            ISequence sequence = new SquareSequence(from, to);

            SequenceValidator validator = new SequenceValidator();

            Assert.True(validator.Validate(sequence).IsValid);
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(36, 35)]
        [InlineData(0, 0)]
        [InlineData(-2, -2)]
        [InlineData(4545, -332)]
        [InlineData(-2323, -994)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        public void ValidateSquareSequenceRangeValuesResultFalse(int from, int to)
        {
            ISequence sequence = new SquareSequence(from, to);

            SequenceValidator validator = new SequenceValidator();

            Assert.False(validator.Validate(sequence).IsValid);
        }
    }
}
