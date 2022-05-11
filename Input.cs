using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public static class Input
    {
        public static void TakeInput()
        {
            Console.SetCursorPosition(0, 50);
            Console.Write("                                                               ");
            Console.SetCursorPosition(0, 50);
            Console.Write("Input: ");
            string input = Console.ReadLine();
            if (input == null || input.Length < 4) return;
            if (input == "reset")
            {
                Console.CursorVisible = false;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Grid.CreateBoard();
                Grid.PrintBoard();
                SquareTracker.CreateSquares();
                SquareTracker.PrintSquares();
                return;
            }
            char[] inputChars = input.Take(4).ToArray();
            if (inputChars[0] == 'W' || input[0] == 'B')
            {
                PlaceNewPiece(inputChars);
                return;
            }
            if 
            (   
                 (int)inputChars[0] >= 97 && (int)inputChars[0] <= 104 &&
                 (int)inputChars[2] >= 97 && (int)inputChars[2] <= 104 &&
                 (int)inputChars[1] >= 49 && (int)inputChars[1] <= 56 &&
                 (int)inputChars[3] >= 49 && (int)inputChars[3] <= 56 )
            {
                SwitchSquares(inputChars);
            }            
        }
        public static void SwitchSquares(char[] inputChars)
        {
            foreach (Square newSquare in SquareTracker.AllSquares)
            {
                if (newSquare.File == inputChars[2] && newSquare.Rank == inputChars[3])
                {
                    foreach (Square oldSquare in SquareTracker.AllSquares)
                    {
                        if (oldSquare.File == inputChars[0] && oldSquare.Rank == inputChars[1])
                        {
                            newSquare.CurrentPiece = oldSquare.CurrentPiece;
                            oldSquare.CurrentPiece = null;
                        }
                    }
                }
            }
        }
        public static void PlaceNewPiece(char[] inputChars)
        {
            ConsoleColor color = ConsoleColor.White;
            if (inputChars[0] == 'B') color = ConsoleColor.Blue;
            switch (inputChars[1])
            {
                case 'B':
                    foreach (Square square in SquareTracker.AllSquares)
                    {
                        if (square.File == inputChars[2] && square.Rank == inputChars[3])
                        {
                            Bishop b = new(inputChars[2], inputChars[3], color);
                            square.CurrentPiece = b;
                            SquareTracker.AllPieces.Add(b);
                        }
                    }                   
                    break;
                case 'K':
                    foreach (Square square in SquareTracker.AllSquares)
                    {
                        if (square.File == inputChars[2] && square.Rank == inputChars[3])
                        {
                            King k = new(inputChars[2], inputChars[3], color);
                            square.CurrentPiece = k;
                            SquareTracker.AllPieces.Add(k);
                        }
                    }
                    break;
                case 'N':
                    foreach (Square square in SquareTracker.AllSquares)
                    {
                        if (square.File == inputChars[2] && square.Rank == inputChars[3])
                        {
                            Knight n = new(inputChars[2], inputChars[3], color);
                            square.CurrentPiece = n;
                            SquareTracker.AllPieces.Add(n);
                        }
                    }
                    break;
                case 'P':
                    foreach (Square square in SquareTracker.AllSquares)
                    {
                        if (square.File == inputChars[2] && square.Rank == inputChars[3])
                        {
                            Pawn p = new(inputChars[2], inputChars[3], color);
                            square.CurrentPiece = p;
                            SquareTracker.AllPieces.Add(p);
                        }
                    }
                    break;
                case 'Q':
                    foreach (Square square in SquareTracker.AllSquares)
                    {
                        if (square.File == inputChars[2] && square.Rank == inputChars[3])
                        {
                            Queen q = new(inputChars[2], inputChars[3], color);
                            square.CurrentPiece = q;
                            SquareTracker.AllPieces.Add(q);
                        }
                    }
                    break;
                case 'R':
                    foreach (Square square in SquareTracker.AllSquares)
                    {
                        if (square.File == inputChars[2] && square.Rank == inputChars[3])
                        {
                            Rook r = new(inputChars[2], inputChars[3], color);
                            square.CurrentPiece = r;
                            SquareTracker.AllPieces.Add(r);
                        }
                    }
                    break;
            }
        }
    }
}
