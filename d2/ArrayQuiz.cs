using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d2
{
    internal class ArrayQuiz
    {
        public static string Quiz1(string input)
        {
            //Remove duplicate character
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (result.IndexOf(input[i]) == -1)
                {
                    result += input[i];
                }
            }
            return result;
        }

        public static string Quiz2(string input)
        {
            //Capitalize first letter
            string result = "";
            string[] arrStr = input.Split(' ');
            for (int i = 0; i < arrStr.Length; i++)
            {
                string temp = arrStr[i].ToLower();
                temp = temp[0].ToString().ToUpper() + temp.Substring(1);
                result += temp + " ";
            }
            return result.Trim();
        }

        public static string[] Quiz3(string[] input, string except)
        {
            // Capitalize except with same value
            string[] result = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == except)
                {
                    result[i] = input[i];
                }
                else
                {
                    string temp = input[i].ToLower();
                    temp = temp[0].ToString().ToUpper() + temp.Substring(1);
                    result[i] = temp;
                }
            }
            return result;
        }

        public static bool Quiz4(string input)
        {
            // Check if braces string is valid
            int openBrances = 0;
            int closeBrances = 0;
            foreach (var item in input)
            {
                if (item == '(')
                {
                    openBrances++;
                }

                if (item == ')')
                {
                    closeBrances++;
                }
            }

            return openBrances == closeBrances;
        }

        public static int[] Quiz5(int[] input)
        {
            // Find Min and Max value
            int[] result = new int[2];
            result[0] = input[0];
            result[1] = input[0];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < result[0])
                {
                    result[0] = input[i];
                }

                if (input[i] > result[1])
                {
                    result[1] = input[i];
                }
            }
            return result;

        }

        public static int[] Quiz6A(int[] input, int min, int max)
        {
            // Find Min and index positon in specific range
            int[] result = new int[2];
            result[0] = input[0];
            result[1] = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < result[0] && i >= min && i <= max)
                {
                    result[0] = input[i];
                    result[1] = i;
                }
            }
            return result;
        }

        public static int[] Quiz6B(int[] input, int min, int max)
        {
            // Find Max and index positon in specific range
            int[] result = new int[2];
            result[0] = input[0];
            result[1] = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > result[0] && i >= min && i <= max)
                {
                    result[0] = input[i];
                    result[1] = i;
                }
            }
            return result;
        }

        public static int[] Quiz7(int[] input)
        {
            //Order just only even number in array and order odd number after even number
            int[] result = new int[input.Length];
            int index = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    result[index] = input[i];
                    index++;
                }
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 != 0)
                {
                    result[index] = input[i];
                    index++;
                }
            }
            return result;
        }

        public static int[] Quiz8(int[] input)
        {
            //Plus one every value in array and add new value if number > 9
            int[] result = new int[input.Length + 1];
            int index = input.Length - 1;
            int carry = 1;
           while (index >= 0)
            {
                int temp = input[index] + carry;
                if (temp > 9)
                {
                    carry = 1;
                    result[index + 1] = temp % 10;
                }
                else
                {
                    carry = 0;
                    result[index + 1] = temp;
                }
                index--;
            }
           if (carry == 1)
            {
                result[0] = 1;
                return result;
            }
            else
            {
                int[] result2 = new int[input.Length];
                for (int i = 0; i < result2.Length; i++)
                {
                    result2[i] = result[i + 1];
                }
                return result2;
            }

        }

        public static int[,] Quiz9(int[,] input, int rotate)
        {
            //Just rotate last row to right and most right move to most left
            int lastRow = input.GetLength(0)-1;
            int col = input.GetLength(1);
            int lastCol = col - 1;
            for (int i = 0; i < rotate; i++)
            {
                for ( int k = 1;  k < col; k++)
                {
                    if (k == lastCol)
                    {
                        int temp = input[lastRow, lastCol];
                        input[lastRow, lastCol] = input[lastRow, 0];
                        input[lastRow, 0] = temp;
                    }
                    else
                    {
                       int temp = input[lastRow, k];
                       input[lastRow, k] = input[lastRow, k + 1];
                       input[lastRow, k + 1] = temp;
                    }
                }
            }


            return input;
        }
    }
}
