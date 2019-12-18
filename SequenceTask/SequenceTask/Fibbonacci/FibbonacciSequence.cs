using SequenceTask.SequenceOfNumbers;
using System;
using System.Collections.Generic;

namespace SequenceTask.Fibbonacci
{
    public class FibbonacciSequence : SequenceSizing
    {
        public FibbonacciSequence(int from, int to)
            :base(from, to)
        {

        }

        public List<int> FibbonacciSequenceCount()
        {
            List<int> fibbonacciSequence = new List<int>();

            if (From >= 2)
            {
                //fibbonacciSequence.Add(1);
            }
            else if(From == 1)
            {
                fibbonacciSequence.Add(1);
            }
            else
            {
                fibbonacciSequence.Add(0);
                fibbonacciSequence.Add(1);
            }

            int currentNumber = 1;
            int previousNumber = 0;

            if (From < 0 || From > To || To < 0)
            {
                throw new NullReferenceException("null sequence");
            }
            else
            {
                bool flag = true;

                do
                {
                    int temp = currentNumber;
                    currentNumber += previousNumber;
                    previousNumber = temp;
                    if(currentNumber >= From)
                    {
                        if(currentNumber <= To)
                        {
                            fibbonacciSequence.Add(currentNumber);
                        }
                        else
                        {
                            return fibbonacciSequence;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                while (flag);

                return fibbonacciSequence;

            }
        }
    }
}
