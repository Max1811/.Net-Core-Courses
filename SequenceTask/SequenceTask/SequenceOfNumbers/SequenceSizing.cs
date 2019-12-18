namespace SequenceTask.SequenceOfNumbers
{
    public abstract class SequenceSizing
    {
        private protected int From { get; }
        private protected int To { get; }

        public SequenceSizing()
        {
            From = 0;
            To = 0;
        }
        public SequenceSizing(int from, int to)
        {
            From = from;
            To = to;
        }
    }
}
