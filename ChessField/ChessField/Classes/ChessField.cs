using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessFieldDrawProgram.Classes
{
    public class ChessField: FieldCell
    {
        private int Width { get; set; }
        private int Height { get; set; }

        public ChessField()
            :base()
        {

        }

        public ChessField(int width, int height, char symbol)
            :base(symbol)
        {
            Width = width;
            Height = height;
        }

        public void DrawField()
        {
            for (int x = 0; x < this.Width; x++)
            {
                string line = "";
                for (int y = 0; y < this.Height; y++)
                {
                    if((x + y) % 2 == 1)
                    {
                        line += CellSymbol;
                    }
                    else
                    {
                        line += ' ';
                    }
                }
                Console.WriteLine(line);
            }
        }
        
    }
}
