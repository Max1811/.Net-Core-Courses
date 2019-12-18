using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIsLetterFits.LetterComponents
{
    public interface ILetter
    {
        int Width { get; }
        int Height { get; }
    }
}
