using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Square
    {
        public int CursorX { get; set; }
        public int CursorY { get; set; }
        public char File { get; set; }
        public char Rank { get; set; }
        public Piece CurrentPiece { get; set; }

        public Square(char file, char rank, int cursorX, int cursorY, Piece currentPiece)
        {
            File = file;
            Rank = rank;
            CursorX = cursorX;
            CursorY = cursorY;
            CurrentPiece = currentPiece;
        }
    }
}
