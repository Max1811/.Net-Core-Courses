using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIsLetterFits.LetterComponents
{
    public class Letter : ILetter
    {
        public int Width { get; } = 0;
        public int Height { get; } = 0;

        public Letter()
        {

        }
        public Letter(int width, int height)
        {
            Width = width;
            Height = height;
        }

    }
}
