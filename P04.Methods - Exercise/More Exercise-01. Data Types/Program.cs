using System;

namespace More_Exercise_01._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input=="int")
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(num*2);
            }
            else if (input=="real")
            {
                double realNum = double.Parse(Console.ReadLine());
                double realSum = realNum * 1.5;
                Console.WriteLine($"{realSum:f2}");
            }
            else if (input=="string")
            {
                string word = Console.ReadLine();
                Console.WriteLine($"${word}$");
            }
        }
    }
}
