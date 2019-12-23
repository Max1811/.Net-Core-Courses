using Sequence.TextMessages;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Sequence
{
    public class SquareSequence: ISequence
    {
        public int From { get; }
        public int To { get; }

        public SquareSequence(int from, int to)
        {
            From = from;
            To = to;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new SquareEnumerator(From, To);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new SquareEnumerator(From, To);
        }

        private class SquareEnumerator : IEnumerator<int>
        {
            private readonly int from;
            private readonly int to;
            private int _current = 1;
            private int _square = 1;

            public SquareEnumerator(int from, int to)
            {
                this.from = from;
                this.to = to;

                CalculateFrom();
            }

            private void CalculateFrom()
            {
                while (true)
                {
                    try
                    {
                        int next = _current * _current;
                        if (next >= from) break;
                        MoveNext();
                    }
                    catch
                    {
                        throw new ArgumentOutOfRangeException(UIMessages.OUT_OF_RANGE_OF_EXEPTION_MESSAGE);
                    }

                }
            }

            public int Current => _square;

            object IEnumerator.Current => _square;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                _square = _current * _current;

                if (_square <= to)
                {
                    
                    _current++;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                _current = 1;
                _square = 1;
                CalculateFrom();
            }
        }
    }
}
