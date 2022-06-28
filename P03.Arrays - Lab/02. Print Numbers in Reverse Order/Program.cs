using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfNumbers = int.Parse(Console.ReadLine());

            int[] item = new int[numOfNumbers];

            for (int i = 0; i < numOfNumbers; i++)
            {
                item[i] = int.Parse(Console.ReadLine());
            }

            for (int i = item.Length-1; i >= 0; i--)
            {
                Console.Write($"{item[i]} ");
            }
        }
    }
}
