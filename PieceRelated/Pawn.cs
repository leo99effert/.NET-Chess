﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Pawn : Piece
    {
        
        public Pawn(char file, char rank, ConsoleColor color) 
            : base(file, rank, color)
        {
            Appearance = CreateAppearance();
        }
        public List<string> CreateAppearance()
        {
            List<string> output = new();
            output.Add("            ");
            output.Add("     ┌┐     ");
            output.Add("    ┌┘└┐    ");
            output.Add("    └──┘    ");
            output.Add("P           ");
            return output;
        }
    }
}
