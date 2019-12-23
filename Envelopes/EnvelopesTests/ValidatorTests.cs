using Envelopes;
using Envelopes.Validator;
using Xunit;


namespace EnvelopeUnitTests
{
    public class ValidatorTests
    {


        [Theory]
        [InlineData(1.503, 5)]
        [InlineData(12334, 0.00000001)]
        [InlineData(232.1, 2)]
        [InlineData(8.03, 8)]
        [InlineData(2, 1)]
        [InlineData(12, 200.00)]
        public void ValidateEnvelopesWidthAndHeightReturnsTrue(double width, double height)
        {
            EnvelopesValidator validator = new EnvelopesValidator();
            Envelope envelope = new Envelope(width, height);

            bool isValidExpected = validator.Validate(envelope).IsValid;

            Assert.True(isValidExpected);
        }

        [Theory]
        [InlineData(0, 5)]
        [InlineData(12334, 0)]
        [InlineData(0, 0)]
        [InlineData(-4, 1)]
        [InlineData(0, -20323)]
        [InlineData(1, -1)]
        [InlineData(12, -0.00001)]
        public void ValidateEnvelopesWidthAndHeightReturnsFalse(double width, double height)
        {
            EnvelopesValidator validator = new EnvelopesValidator();
            Envelope envelope = new Envelope(width, height);

            bool isValidExpected = validator.Validate(envelope).IsValid;

            Assert.False(isValidExpected);
        }
    }
}
