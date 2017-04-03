using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _8queens
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {

                bool[,] board = initializeBoard(8); //initialize for 8x8 (8 queens)

                Console.WriteLine(calculateCollisions(board));
                Thread.Sleep(1000);
            }

        }

        static bool[,] initializeBoard(int size)
        {
            bool[,] board = new bool[size, size];
            Random rnd = new Random();


            for (int i = 0; i < size; i++)
            {
                int randomSquare = rnd.Next(8); //placing queen to a random square in the row
                for (int j = 0; j < size; j++)
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
            int size = Convert.ToInt32(Math.Sqrt(board.Length)); //if the board is 8x8, board.Length will be 64
            int totalCollisions = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (board[i, j] == true) // if there is a queen on that square
                    {
                        //for (int z = j + 1; z < size; z++) //check the row
                        //{
                        //    if (board[i, z] == true)
                        //    {
                        //        totalCollisions++;
                        //        break;
                        //    }
                        //}

                        for (int z = i + 1; z < size; z++) //check the column
                        {
                            if (board[z, j] == true)
                            {
                                totalCollisions++;
                                break;
                            }
                        }

                        for (int z = 1; i + z < size && j + z < size; z++) //check the bottom-right diagonal
                        {
                            if (board[i + z, j + z] == true)
                            {
                                totalCollisions++;
                                break;
                            }
                        }

                        for (int z = 1; i - z >= 0 && j + z < size; z++) //check the top-right diagonal
                        {
                            if (board[i - z, j + z] == true)
                            {
                                totalCollisions++;
                                break;
                            }
                        }

                    }
                }
            }
            return totalCollisions;

        }

        //static int calculateCollisions(bool[,] board)


    }
}
