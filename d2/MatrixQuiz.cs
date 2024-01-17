using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d2
{
    internal class MatrixQuiz
    {
        public static int[,] Quiz1(int n )
        {
            int[,] matrix = new int[n, n];
            int last = matrix.GetLength(1) - 1;
            int counter1 = 0, counter2 = last;
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (i > 0 && i < last && k > 0 && k < last)
                    {
                        Console.Write($"{" ",-10}");
                    }
                    else if (i == 0)
                    {
                        matrix[i, k] = k;
                        Console.Write($"{k,-10}");
                    }
                    else if (k == 0 && i > 0)
                    {
                        counter1++;
                        matrix[i, k] = counter1;
                        Console.Write($"{counter1,-10}");
                    }
                    else if (k == last && i > 0)
                    {
                        counter2++;
                        matrix[i, k] = counter2;
                        Console.Write($"{counter2,-10}");
                    }
                    else if (i == last && k > 0 && k < last)
                    {
                        counter1++;
                        matrix[i, k] = counter1;
                        Console.Write($"{counter1,-10}");
                    }

                }
                Console.WriteLine();
            }
            return matrix;
        }

        public static int[,] Quiz2(int n)
        {
  
            int m = n + 1;
            int last = m - 1;
            int counter = 0;
            int[,] result = new int[m, m];
            for (int i = 0; i < m; i++)
            {
                int tempH = 0;
                for (int k = 0; k < m; k++)
                {
                    if (k != last && i != last)
                    {
                        Console.Write($"{k + counter,-10}");
                        result[i, k] = k + counter;
                        tempH += k + counter;
                    }
                    else if (i == last && k == last && k == i)
                    {
                        int tempD = 0;
                        for (int j = 0; j < n; j++)
                        {
                            tempD += result[j, j];
                        }
                        Console.Write($"{tempD,-10}");
                        result[i, k] = tempD;
                    }
                    else if (k == last && i < m)
                    {
                        Console.Write($"{tempH,-10}");
                        result[i, k] = tempH;
                    }
                    else if (i == last && k < m)
                    {
                        int tempV = 0;
                        for (int j = 0; j < n; j++)
                        {
                            tempV += result[j, k];
                        }
                        Console.Write($"{tempV,-10}");
                        result[i, k] = tempV;
                    }

                }
                counter++;
                Console.WriteLine();
            }
            return result;
        }

        public static int[,] Quiz3(int n)
        {
            int b = 3;
            int a = 2;
            int stopper = b + 1;
            int[,] result = new int[n, n];
            int un = (n - 1) * 3;
            int length = n - 1;
            int init = ((n - (n / stopper) - 1) * b) + a;
            int diagonal = init;
            int ui = n;
            int last = ((un - (un / stopper) - 1) * b) + a;
            int horizontal = last;
            int uh = un;
            int uv = n;
            int vertical = init;

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (i + k != length && k != length && i != length)
                    {
                        Console.Write($"{0,-10}");
                    }
                    else if (i + k == length)
                    {
                        if (ui % (stopper) != 0)
                        {
                            Console.Write($"{diagonal,-10}");
                            result[i, k] = diagonal;
                            diagonal -= b;
                        }
                        else
                        {
                            Console.Write($"{Math.Pow(b, (ui / stopper)),-10}");
                            result[i, k] = (int)Math.Pow(b, (ui / stopper));
                        }
                        ui--;
                    }
                    else if (k == length && i > 0)
                    {
                        uv++;
                        if (uv % (stopper) != 0)
                        {
                            vertical += b;
                            result[i, k] = vertical;
                            Console.Write($"{vertical,-10}");
                        }
                        else
                        {
                            Console.Write($"{Math.Pow(b, (uv / stopper)),-10}");
                            result[i, k] = (int)Math.Pow(b, (uv / stopper));
                        }
                    }
                    else if (i == length && k > 0 && k < length)
                    {
                        if (uh % (stopper) != 0)
                        {
                            Console.Write($"{horizontal,-10}");
                            result[i, k] = horizontal;
                            horizontal -= b;
                        }
                        else
                        {
                            Console.Write($"{Math.Pow(b, (uh / stopper)),-10}");
                            result[i, k] = (int)Math.Pow(b, (uh / stopper));
                        }
                        uh--;
                    }
                }
                Console.WriteLine();
            }


            return result;
        }

        public static int[,] Quiz4()
        {
            int n = 7;
            int first = 0, last = n - 1, b = 3, stopper = b + 1;
            int[,] result = new int[n, n];
            int a = 2, un = (n - 1) * 4;
            int an = (un - (un / stopper) - 1) * b + a;
            int ux = 1;

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (i != first && i != last && k != first && k != last)
                    {
                        Console.Write($"{" ",-10}");

                    }
                    else
                    {
                        if (i == first)
                        {
                            if (ux % stopper != 0)
                            {
                                Console.Write($"{a,-10}");
                                result[i, k] = a;
                                a += b;
                            }
                            else
                            {
                                result[i, k] = b;
                                Console.Write($"{b,-10}");
                            }

                            ux++;
                        }
                        else if (i == last && k > first && k < last)
                        {

                            if (un % stopper != 0)
                            {
                                Console.Write($"{an,-10}");
                                result[i, k] = an;
                                an -= b;
                            }
                            else
                            {
                                result[i, k] = b;
                                Console.Write($"{b,-10}");
                            }

                            un--;
                        }
                        else if (k == first && i > first)
                        {
                            if (un % stopper != 0)
                            {
                                Console.Write($"{an,-10}");
                                result[i, k] = an;
                                an -= b;
                            }
                            else
                            {
                                Console.Write($"{b,-10}");
                                result[i, k] = b;
                            }
                            un--;
                        }
                        else if (k == last && i > first)
                        {
                            if (ux % stopper != 0)
                            {
                                Console.Write($"{a,-10}");
                                result[i, k] = a;
                                a += b;
                            }
                            else
                            {
                                result[i, k] = b;
                                Console.Write($"{b,-10}");
                            }
                            ux++;

                        }

                    }
                }
                Console.WriteLine();
            }
            return result;
        }

        public static void Quiz5(char[,] studentAnswers, char[] answer)
        {
            int row = studentAnswers.GetLength(0);
            int[] result = new int[row];
            int col = studentAnswers.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                int counter = 0;
                for (int k = 0; k < col; k++)
                {
                    if (studentAnswers[i, k] == answer[k])
                    {
                        counter++;
                    }
                    result[i] = counter;
                }

            }
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Mahasiswa-{i} yang benar: {result[i]}");
            }
        }



    }
}
