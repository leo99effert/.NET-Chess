using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Knight : Piece
    {
        public Knight(char file, char rank, ConsoleColor color) : base(file, rank, color)
        {
            Appearance = CreateAppearance();
        }
        public List<string> CreateAppearance()
        {
            List<string> output = new();
            output.Add("     _____  ");
            output.Add("    \\     \\ ");
            output.Add("   _/ '   | ");
            output.Add("  (__  /  | ");
            output.Add("N   /     | ");
            return output;
        }
    }
}
