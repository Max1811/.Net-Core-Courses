using Envelopes;
using Xunit;

namespace EnvelopesTests
{
    public class CompareEnvelopesTests
    {
        [Theory]
        [InlineData(2, 6, 1, 1)]
        [InlineData(1, 1, 0.8, 0.2)]
        [InlineData(35, 35, 34, 33)]
        [InlineData(123, 2, 2, 1)]
        [InlineData(2, 3, 2, 1.99999)]
        [InlineData(1000, 1000, 999.999999, 999.99999)]
        [InlineData(0.001, 0.001, 0.0001, 0.0001)]
        public void IsOneEnvelopeContainsAnotherResultTrue(double firstWidth, double firstHeight, double secondWidth, double secondHeight)
        {
            Envelope firstEnvelope = new Envelope(firstWidth, firstHeight);
            Envelope secondEnvelope = new Envelope(secondWidth, secondHeight);

            Assert.True(firstEnvelope.IsFits(secondEnvelope));
        }
    }
}
