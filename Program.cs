using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Grid.CreateBoard();
            Grid.PrintBoard();
            SquareTracker.CreateSquares();
            SquareTracker.PrintSquares();

            while (true)
            {
                Input.TakeInput();
                SquareTracker.PrintSquares();
            }
        }
    }
}
