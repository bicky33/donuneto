using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d3
{
   internal class DataCollection
    {
        public static void InitList()
        {
            var alfabet = new List<string> { "A", "B", "C", "D", "E" };
            alfabet.Add("F");
            alfabet.AddRange(new List<string> { "G", "H", "I", "J", "K" });
            alfabet.Insert(0, "Z");

            var number = new List<int> { 1, 2, 3, 4, 5 };
            number.Add(6);  
            number.AddRange(new List<int> { 7, 8, 9, 10, 11 });
            //number.RemoveAll(x=> x%2==0);
            foreach (var item in number)
            {
                Console.WriteLine(item);
            }
        }
    }

}
