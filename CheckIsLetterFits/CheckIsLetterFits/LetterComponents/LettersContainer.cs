using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIsLetterFits.LetterComponents
{
    public class LettersContainer<T> where T : ILetter
    {
        Tuple<T, T> LettersPair { get; }

        public LettersContainer(T letterOne, T letterTwo)
        {
            LettersPair = new Tuple<T, T>(letterOne, letterTwo);
        }

        public string IsFits()
        {
            if (LettersPair.Item1.Width >= LettersPair.Item2.Width
                && LettersPair.Item1.Height == LettersPair.Item2.Height)
            {
                return "Letter 2 fits int letter 1";
            }
            else if (LettersPair.Item2.Width >= LettersPair.Item1.Width
                && LettersPair.Item2.Height == LettersPair.Item1.Height)
            {
                return "Letter 1 fits int letter 2";
            }

            return "Letters doesnt fit to each other";

        }
    }
}
