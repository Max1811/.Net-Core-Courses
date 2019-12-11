

namespace ChessFieldDraw.FieldComponents
{
    public class CellSymbols
    {
        public char WhiteSymb { get; protected set; }
        public char BlackSymb { get; protected set; }

        public CellSymbols()
        {
            WhiteSymb = ' ';
            BlackSymb = '*';
        }

        public CellSymbols(char blackSymb, char whiteSymb)
        {
            WhiteSymb = whiteSymb;
            BlackSymb = blackSymb;
        }
    }
}
