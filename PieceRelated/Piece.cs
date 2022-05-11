using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Piece
    {
        public List<string> Appearance { get; set; }
        public char File { get; set; }
        public char Rank { get; set; }
        public ConsoleColor Color { get; set; }
        public Piece(char file, char rank, ConsoleColor color)
        {
            File = file;
            Rank = rank;
            Color = color;
        }

    }
}
