using System;
using System.Linq;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] result = Console.ReadLine().Split().Where(word => word.Length % 2 == 0).ToArray();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}