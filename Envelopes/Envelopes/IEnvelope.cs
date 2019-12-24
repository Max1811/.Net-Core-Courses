namespace Envelopes
{
    public interface IEnvelope: IContainable<IEnvelope>
    {
        double Height { get; }
        double Width { get; }
    }
}
