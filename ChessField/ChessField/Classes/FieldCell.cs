using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessFieldDrawProgram.Classes
{
    public class FieldCell
    {
        protected char CellSymbol { get; set; }

        public FieldCell()
        {
            CellSymbol = ' ';
        }
        public FieldCell(char symbol)
        {
            this.CellSymbol = symbol;
        }
    }
}
