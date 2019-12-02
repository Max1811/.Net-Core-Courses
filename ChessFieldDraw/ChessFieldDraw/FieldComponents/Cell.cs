using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessFieldDraw.FieldComponents
{
    public class Cell
    {
        protected char CellSymbol { get; set; }

        public Cell()
        {
            CellSymbol = ' ';
        }
        public Cell(char symbol)
        {
            this.CellSymbol = symbol;
        }
    }
}
