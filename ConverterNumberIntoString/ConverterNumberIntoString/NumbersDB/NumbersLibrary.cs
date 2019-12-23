using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterNumberIntoString.NumbersDB
{
    public class NumbersLibrary: LibraryItems
    {
        public override Dictionary<int, string> Rank { get; protected set; } = new Dictionary<int, string>
        {
            { 1, "Hundred" },
            { 2, "Million" },
            { 3, "Billion" }
        };

        public override Dictionary<int, string> Units { get; protected set; } = new Dictionary<int, string>
        {
            { 1, "One" },
            { 2, "Two" },
            { 3, "Three" },
            { 4, "Four" },
            { 5, "Five" },
            { 6, "Six" },
            { 7, "Seven" },
            { 8, "Eight" },
            { 9, "Nine" }
        };

        public override Dictionary<int, string> Tens { get; protected set; } = new Dictionary<int, string>
        {
            { 1, "Ten" },
            { 2, "Twenty" },
            { 3, "Thirty" },
            { 4, "Fourty" },
            { 5, "Fifty" },
            { 6, "Sixty" },
            { 7, "Seventy" },
            { 8, "Eightty" },
            { 9, "Ninety" }
        };



    }
}
