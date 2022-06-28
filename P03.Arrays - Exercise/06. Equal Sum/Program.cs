using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();


            for (int i = 0; i < array.Length; i++)
            {
                int left = 0;
                int right = 0;
                for (int j = 0; j < i; j++)
                {
                    left += array[j];
                }
                for (int k = i+1; k < array.Length; k++)
                {
                    right += array[k];
                }
                if (left == right)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
