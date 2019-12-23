using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterNumberIntoString.NumbersDB
{
    public abstract class LibraryItems
    {
        public abstract Dictionary<int, string> Rank { get; protected set; } // разряды
        public abstract Dictionary<int, string> Tens { get; protected set; } // десятки
        public abstract Dictionary<int, string> Units { get; protected set; }
        public Dictionary<int, string> WordsEndings { get; protected set; }
    }
}
