namespace Envelopes
{
    public interface IContainable<T> where T : IEnvelope
    {
        bool IsFits(T secondEnvelope);
    }
}
