using ConverterNumberIntoString.RankComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterNumberIntoString
{
    public class ParsedNumber
    {
        Stack<RankItem> Number { get; }

        private const int RANK = 3;
        public ParsedNumber(int number)
        {
            Number = ParsedNumber(number);
        }

        private Stack<RankItem> ParsedNumber(int number)
        {
            Stack<int> parsedNumber = new Stack<int>();

            bool flag = true;
            do
            {
                int currentRank = number % 1000;
            }
            while (flag);

        }
    }
}
