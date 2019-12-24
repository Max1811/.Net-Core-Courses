namespace Envelopes
{
    public class Envelope : IEnvelope
    {
        public double Width { get; protected set; }
        public double Height { get; protected set; }

        public Envelope(double firstSide, double secondSide)
        {
            Width = firstSide;
            Height = secondSide;
        }
        public Envelope(double[] parametrs)
        {
            Width = parametrs[0];
            Height = parametrs[1];
        }

        public bool IsFits(IEnvelope secondEnvelope)
        {
            return (Height > secondEnvelope.Height && Width > secondEnvelope.Width) 
                || (Height > secondEnvelope.Width && Width > secondEnvelope.Height);
        }
    }
}
