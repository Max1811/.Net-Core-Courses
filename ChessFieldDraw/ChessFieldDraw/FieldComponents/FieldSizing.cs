

namespace ChessFieldDraw.FieldComponents
{
    public abstract class FieldSizing
    {
        public int Width { get; protected set; }
        public int Height { get; protected set; }

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
