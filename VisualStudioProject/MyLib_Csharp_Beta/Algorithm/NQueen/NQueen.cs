using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.Algorithm
{
    public partial class NQueen
    {
        public static int SolveNQueen(int n)
        {
            char[,] board = new char[n, n];
            int size = n;
            int count = 0;

            void EightQueen_body(char[,] board, int n, int row)
            {
                if (n == 0)
                {
                    // PrintBoard(board, size);
                    count++;
                    return;
                }
                for (int col = 0; col < size; col++)
                {
                    if (board[row, col] != '\0') continue;

                    char[,] newBoard = (char[,])board.Clone();

                    // | ——
                    for (int i = 0; i < size; i++)
                    {
                        newBoard[row, i] = '1';
                        newBoard[i, col] = '1';
                    }

                    // \
                    int j = 0;
                    while (row + j != 0 && col + j != 0) j--;
                    for (; row + j < size && col + j < size; j++)
                    {
                        newBoard[row + j, col + j] = '1';
                    }

                    // /
                    j = 0;
                    while (row + j != 0 && col - j != size - 1) j--;
                    for (; row + j < size && col - j >= 0; j++)
                    {
                        newBoard[row + j, col - j] = '1';
                    }

                    // .
                    newBoard[row, col] = '2';

                    EightQueen_body(newBoard, n - 1, row + 1);
                    // PrintBoard(newBoard, size);
                }
            }

            EightQueen_body(board, n, 0);
            return count;
        }

        public static void PrintBoard(char[,] board, int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(board[row, col] == '\0' ? '0' : board[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
