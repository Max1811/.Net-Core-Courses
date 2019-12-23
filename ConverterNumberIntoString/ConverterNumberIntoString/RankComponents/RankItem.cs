using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterNumberIntoString.RankComponents
{
    public class RankItem
    {
        Queue<int> RankNumbers { get; }

        public RankItem(int num1, int num2, int num3)
        {
            RankNumbers = InitializeRankNumbers(num1, num2, num3);
        }

        private Queue<int> InitializeRankNumbers(int num1, int num2, int num3)
        {
            Queue<int> rank = new Queue<int>();
            rank.Enqueue(num1);
            rank.Enqueue(num2);
            rank.Enqueue(num3);
            return rank;
        }
    }
}
