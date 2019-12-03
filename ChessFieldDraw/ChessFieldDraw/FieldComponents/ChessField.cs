using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessFieldDraw.FieldComponents
{
    public class ChessField : FieldSizing
    {
        private Cell[,] field;
        
        public ChessField(int width, int height)
            : base(width, height)
        {
            field = new Cell[Width, Height];
            FieldMethods.InitializeField(field, Width, Height);
        }

        public Cell this[int width, int height]
        {
            get
            {
                return field[width, height];
            }
            set
            {
                field[width, height] = value;
            }
        }

        

        public void DrawField(CellSymbols symbols)
        {
            FieldMethods.DisplayField(field, Width, Height, symbols);
        }
    }
}

