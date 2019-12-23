using Sequence.TextMessages;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Sequence
{
    public class FibbonacciSequence : ISequence
    {
        public int From { get; }
        public int To { get; }

        public FibbonacciSequence(int from, int to)
        {
            From = from;
            To = to;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new FibonacciEnumerator(From, To);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new FibonacciEnumerator(From, To);
        }

        private class FibonacciEnumerator : IEnumerator<int>
        {
            private int from;
            private int to;
            private int _current = 1;
            private int _prev = 0;

            public FibonacciEnumerator(int from, int to)
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
                        int next = _current + _prev;
                        if (next >= from) break;
                        MoveNext();
                    }
                    catch
                    {
                        throw new ArgumentOutOfRangeException(UIMessages.OUT_OF_RANGE_OF_EXEPTION_MESSAGE);
                    }
                    
                }
            }

            public int Current => _prev;

            object IEnumerator.Current => _prev;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                var result = _prev + _current;
                if (_prev <= to && _prev < int.MaxValue)
                {
                    if (from <= 0)
                    {
                        from++;
                    }
                    else
                    {
                        _prev = _current;
                        _current = result;
                    }

                    return true;
                }
                
                return false;
            }

            public void Reset()
            {
                _current = 1;
                _prev = 0;
                CalculateFrom();
            }
        }
    }
}
