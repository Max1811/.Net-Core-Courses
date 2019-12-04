using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessFieldDraw.FieldComponents
{
    public class CellSymbols
    {
        public char WhiteSymb { get; set; }
        public char BlackSymb { get; set; }

        public CellSymbols()
        {
            WhiteSymb = ' ';
            BlackSymb = '*';
        }

        public CellSymbols(char blackSymb, char whiteSymb)
        {
            WhiteSymb = whiteSymb;
            BlackSymb = blackSymb;
        }
    }
}
