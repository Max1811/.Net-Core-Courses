

namespace ChessFieldDraw.FieldComponents
{
    public class ChessField : FieldSizing
    {
        public Cell[,] Field { get; set; }
        public CellSymbols DisplaySymbols { get; protected set; }

        public ChessField(int width, int height, CellSymbols displaySymbols)
            : base(width, height)
        {
            Field = new Cell[Width, Height];
            DisplaySymbols = displaySymbols;
            InitializeField();
        }

        public Cell this[int width, int height]
        {
            get
            {
                return Field[width, height];
            }
            set
            {
                Field[width, height] = value;
            }
        }

        public void InitializeField()
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    if ((x + y) % 2 == 1)
                    {
                        Field[x, y].Color = CellColors.White;
                    }
                    else
                    {
                        Field[x, y].Color = CellColors.Black;
                    }
                }
            }
        }
    }
}

