using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d2
{
    internal class Arr
    {
        public static void IntroArray()
        {
            int[] arr = new int[5];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;

            double[] arr2 = new double[5];
            arr2[0] = 1.1;
            arr2[1] = 2.2;

            //initialization array
            double[] price = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 };
            string[] names = new string[] { "Andi", "Budi", "Caca" };
            char[] grade = new char[] { 'A', 'B', 'C' };

            //display array
            foreach (double item in price)
            {
                Console.WriteLine(item);
            }
        }

        public static int[] InitArrayInteger(int n)
        {
            int[] arrInt = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                arrInt[i] = rnd.Next(51);
            }   
            return arrInt;
        }   

        public static void DisplayInitArrayInteger(int[] arrInt)
        {
            foreach (int item in arrInt)
            {
                Console.Write($"{item.ToString()} ");
            }
        }   

        public static int SumArrayInteger(int[] arrInt)
        {
            int sum = 0;
            foreach (int item in arrInt)
            {
                sum += item;
            }
            return sum;
        }   

        public static int MaxArrayInteger(int[] arrInt)
        {
            int max = arrInt[0];
            foreach (int item in arrInt)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        public static int FindMaxIndex(int[] arrInt)
        {
            int max = arrInt[0];
            int index = 0;
            for (int i = 0; i < arrInt.Length; i++)
            {
                if (arrInt[i] > max)
                {
                    max = arrInt[i];
                    index = i;
                }
            }
            return index;
        }   

        public static int[] CopyArrayInteger(int[] source)
        {
            int[] dest = new int[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                dest[i] = source[i];
            }
            return dest;

        }   
    }
}
