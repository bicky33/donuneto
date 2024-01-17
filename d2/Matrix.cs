using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d2
{
    internal class Matrix
    {
        public static void InitMatrix()
        {
            int[,] matrix = new int[5, 5];
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[0, 3] = 4;
            matrix[0, 4] = 5;

        }

        public static int[,] FillRandomMatrix(int row, int col)
        {
            int[,] matrix = new int[row, col];
            Random rnd = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int k = 0; k < col; k++)
                {
                    matrix[i, k] = rnd.Next(21);
                }
            }
            return matrix;
        }

        public static void DisplayMatrix(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                Console.Write("|");
                for (int k = 0; k < col; k++)
                {
                    Console.Write($"{matrix[i, k].ToString()}|");
                }
                Console.WriteLine();
            }
        }   

        public static void DisplayDiagonalMatrix(int col, int row)
        {
            int[,] matrix = new int[row, col];
            int counter = 0;
            for (int i = 0; i < row; i++)
            {
                for (int k = 0; k < col; k++)
                {
                    if (i == k)
                    {
                        matrix[i, k] = counter;
                        counter++;
                    } else if(i > k)
                    {
                        matrix[i, k] = 1;
                    } else
                    {
                        matrix[i, k] = 0;
                    }
                }
            }
            DisplayMatrix(matrix);
        }   
    }
}
