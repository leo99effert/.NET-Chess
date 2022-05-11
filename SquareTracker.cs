using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public static class SquareTracker
    {
        public static Square[,] AllSquares { get; set; } = new Square[8, 8];
        public static List<Piece> AllPieces { get; set; } = new();
        public static void CreateSquares()
        {         
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    char file = (char)(x + 97);
                    char rank = (char)(56 - y);
                    AllSquares[x, y] = new Square(file, rank, (13 * x + 1), (6 * y + 1), CreatePiece(file, rank));
                }
            }
        }
        public static void PrintSquares()
        {
            foreach (Square square in SquareTracker.AllSquares)
            {               
                if (square.CurrentPiece != null)
                {
                    Console.ForegroundColor = square.CurrentPiece.Color;
                    Console.SetCursorPosition(square.CursorX, square.CursorY);
                    Console.Write(square.CurrentPiece.Appearance[0]);
                    Console.SetCursorPosition(square.CursorX, square.CursorY + 1);
                    Console.Write(square.CurrentPiece.Appearance[1]);
                    Console.SetCursorPosition(square.CursorX, square.CursorY + 2);
                    Console.Write(square.CurrentPiece.Appearance[2]);
                    Console.SetCursorPosition(square.CursorX, square.CursorY + 3);
                    Console.Write(square.CurrentPiece.Appearance[3]);
                    Console.SetCursorPosition(square.CursorX, square.CursorY + 4);
                    Console.Write(square.CurrentPiece.Appearance[4]);
                }
                else
                {
                    Console.SetCursorPosition(square.CursorX, square.CursorY);
                    Console.Write("            ");
                    Console.SetCursorPosition(square.CursorX, square.CursorY + 1);
                    Console.Write("            ");
                    Console.SetCursorPosition(square.CursorX, square.CursorY + 2);
                    Console.Write("            "); ;
                    Console.SetCursorPosition(square.CursorX, square.CursorY + 3);
                    Console.Write("            ");
                    Console.SetCursorPosition(square.CursorX, square.CursorY + 4);
                    Console.Write("            ");
                }
            }
        }
        public static Piece CreatePiece(char file, char rank)
        {
            if (rank == '2')
            {
                Pawn p = new(file, rank, ConsoleColor.White);
                AllPieces.Add(p);
                return p;
            }
            else if (rank == '7')
            {
                Pawn p = new(file, rank, ConsoleColor.Blue);
                AllPieces.Add(p);
                return p;
            }
            switch (file, rank)
            {
                case ('a', '1'):
                    Rook ra1 = new(file, rank, ConsoleColor.White);
                    AllPieces.Add(ra1);
                    return ra1;
                case ('b', '1'):
                    Knight nb1 = new(file, rank, ConsoleColor.White);
                    AllPieces.Add(nb1);
                    return nb1;
                case ('c', '1'):
                    Bishop bc1 = new(file, rank, ConsoleColor.White);
                    AllPieces.Add(bc1);
                    return bc1;
                case ('d', '1'):
                    Queen qd1 = new(file, rank, ConsoleColor.White);
                    AllPieces.Add(qd1);
                    return qd1;
                case ('e', '1'):
                    King ke1 = new(file, rank, ConsoleColor.White);
                    AllPieces.Add(ke1);
                    return ke1;
                case ('f', '1'):
                    Bishop bf1 = new(file, rank, ConsoleColor.White);
                    AllPieces.Add(bf1);
                    return bf1;
                case ('g', '1'):
                    Knight ng1 = new(file, rank, ConsoleColor.White);
                    AllPieces.Add(ng1);
                    return ng1;
                case ('h', '1'):
                    Rook rh1 = new Rook(file, rank, ConsoleColor.White);
                    AllPieces.Add(rh1);
                    return rh1;
                case ('a', '8'):
                    Rook ra8 = new(file, rank, ConsoleColor.Blue);
                    AllPieces.Add(ra8);
                    return ra8;
                case ('b', '8'):
                    Knight nb8 = new(file, rank, ConsoleColor.Blue);
                    AllPieces.Add(nb8);
                    return nb8;
                case ('c', '8'):
                    Bishop bc8 = new(file, rank, ConsoleColor.Blue);
                    AllPieces.Add(bc8);
                    return bc8;
                case ('d', '8'):
                    Queen qd8 = new(file, rank, ConsoleColor.Blue);
                    AllPieces.Add(qd8);
                    return qd8;
                case ('e', '8'):
                    King ke8 = new(file, rank, ConsoleColor.Blue);
                    AllPieces.Add(ke8);
                    return ke8;
                case ('f', '8'):
                    Bishop bf8 = new(file, rank, ConsoleColor.Blue);
                    AllPieces.Add(bf8);
                    return bf8;
                case ('g', '8'):
                    Knight ng8 = new(file, rank, ConsoleColor.Blue);
                    AllPieces.Add(ng8);
                    return ng8;
                case ('h', '8'):
                    Rook rh8 = new Rook(file, rank, ConsoleColor.Blue);
                    AllPieces.Add(rh8);
                    return rh8;
                default:
                    return null;
            }
        }
    }
}
