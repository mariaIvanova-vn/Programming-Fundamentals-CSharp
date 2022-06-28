using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> input =Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> result = new List<string>();

            for (int i = input.Count-1; i >= 0; i--)
            {
                var currList = input[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in currList)
                {
                    result.Add(item);
                }
            }
            Console.WriteLine(String.Join(" ",result));
        }
    }
}
