using SequenceTask.SequenceOfNumbers;
using System;
using System.Collections.Generic;

namespace SequenceTask.SquareCheck
{
    public class ExponentSequence : SequenceSizing
    {
        private readonly double POWER;
        public ExponentSequence(int from, int to, int power)
            : base(from, to)
        {
            POWER = power;
        }

        public List<int> SelectPows()
        {
            int number = 0;

            if (From < 0 || From > To || To < 0)
            {
                throw new NullReferenceException("null sequence");
            }

            bool flag = true;

            List<int> NumsSequence = new List<int>();

            do
            {
                int squareNum;

                try
                {
                    squareNum = (int)(Math.Pow(number, POWER));
                }
                catch
                {
                    throw new OverflowException("number is out of range");
                }
                
                if (squareNum >= From)
                {
                    if(squareNum <= To)
                    {
                        NumsSequence.Add(squareNum);
                        number++;
                    }
                    else
                    {
                        return NumsSequence;
                    }
                }
                else
                {
                    number++;
                    continue;
                }
            }
            while (flag);
            return NumsSequence;
        }
    }
}
