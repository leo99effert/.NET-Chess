using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public static class Grid
    {
        public static char[,] Board { get; set; } = new char[105, 49]; // each square == (12, 5)       
        public static void PrintBoard()
        {
            for (int x = 0; x < 105; x++)
            {
                for (int y = 0; y < 49; y++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(Board[x, y]);
                }
            }
            PrintFilesAndRanks();
        }
        public static void PrintFilesAndRanks()
        {
            for (int i = 0; i < 8; i++)
            {
                Console.SetCursorPosition(106, i + 3 + i * 5);
                Console.Write(8 - i);
                Console.SetCursorPosition(i + 6 + i * 12, 49);
                Console.Write((char)(i + 97));
            }
        }
        public static void CreateBoard()
        {
            for (int x = 0; x < 105; x++)
            {
                for (int y = 0; y < 49; y++)
                {
                    if (x % 13 == 0 && y == 0) Board[x, y] = '┬';
                    else if (x % 13 == 0 && y == 48) Board[x, y] = '┴';
                    else if (y % 6 == 0 && x == 0) Board[x, y] = '├';
                    else if (y % 6 == 0 && x == 104) Board[x, y] = '┤';
                    else if (x % 13 == 0 && y % 6 == 0) Board[x, y] = '┼';
                    else if (x % 13 == 0) Board[x, y] = '│';
                    else if (y % 6 == 0) Board[x, y] = '─';
                    else Board[x, y] = ' ';
                }
            }
            Board[0, 0] = '┌';
            Board[0, 48] = '└';
            Board[104, 0] = '┐';
            Board[104, 48] = '┘';
        }  
    }
}
