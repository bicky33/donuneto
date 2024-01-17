using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d1
{
    internal class Quiz
    {
        public static void Quiz1(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int k = n - i; k < n; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int k = n; k > i+1; k--)
                {
                    Console.Write(" ");
                }
                for (int j = n-i-1; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Quiz2()
        {
            Console.Write("Input Jumlah Baris Piramida: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = n-i; j > 0; j--)
                {
                    Console.Write(j);
                }
                for (int k = 2;  k < n-i+1; k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
        }

        public static void Quiz3(int n)
        {
            string result = "";
            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i/2; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    result += $" {i},";
                }
            }

            Console.WriteLine(result.Substring(0, result.Length-1));
        }
        public static void Quiz4(int n)
        {
            for (int i = 1; i < n; i++)
            {
                if (n%i == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        public static void Quiz5(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j%2 != 0)
                    {
                        Console.Write(i+1);
                    } else
                    {
                        Console.Write(n-i);
                    }
                }
                Console.WriteLine();
            }
        }

        public static void Quiz6(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i % 2 != 0)
                    {
                        if (j % 2 ==0)
                        {
                            Console.Write(j);
                        } else
                        {
                            Console.Write("-");
                        }
                    }
                    else
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write(j);
                        }
                        else
                        {
                            Console.Write("-");
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        public static void Quiz7(int n)
        {
            for (int i = 1; i < n; i++)
            {
                int temp = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0 && i != j)
                    {
                        temp += j;
                    }
                }

                if(i == temp)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }

        public static bool Quiz8(int n)
        {
            string o = n.ToString();

            for (int i = 0; i < o.Length / 2; i++)
            {
                if (o[i] != o[o.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
