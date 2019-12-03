using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessFieldDraw.FieldComponents
{
    public class FieldMethods
    {
        public static void InitializeField(Cell[,] field, int width, int height)
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if ((x + y) % 2 == 1)
                    {
                        field[x, y].Color = CellColors.White;
                    }
                    else
                    {
                        field[x, y].Color = CellColors.Black;
                    }
                }
            }
        }

        
        public static void DisplayField(Cell[,] field, int width, int height, CellSymbols symbols)
        {
            for (int x = 0; x < width; x++)
            {
                string line = "";
                for (int y = 0; y < height; y++)
                {
                    if (field[x, y].Color == CellColors.White)
                    {
                        line += symbols.WhiteSymb;
                    }
                    else
                    {
                        line += symbols.BlackSymb;
                    }
                }
                Console.WriteLine(line);
            }
        }

    }
}
