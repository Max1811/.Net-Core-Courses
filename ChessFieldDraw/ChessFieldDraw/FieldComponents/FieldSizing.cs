using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessFieldDraw.FieldComponents
{
    public abstract class FieldSizing
    {
        protected int Width { get; set; }
        protected int Height { get; set; }

        public FieldSizing()
        {
            Width = 0;
            Height = 0;
        }

        public FieldSizing(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
    }
}
