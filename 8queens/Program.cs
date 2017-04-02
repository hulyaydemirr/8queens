using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8queens
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] board= initializeBoard(8); //initialize for 8x8 (8 queens)




        }

        static bool[,] initializeBoard(int size)
        {
            bool[,] board = new bool[size, size];
            Random rnd = new Random();


            for (int i = 0; i < size - 1; i++)
            {
                int randomSquare = rnd.Next(8); //placing queen to a random square in the row
                for (int j = 0; j < size - 1; j++)
                {
                    if (j != randomSquare)
                        board[i, j] = false;
                    else
                        board[i, j] = true; 
                }
            }

            return board;
        }

        static int calculateCollisions(bool[,] board)
        {
            return 0;

        }
    }
}
