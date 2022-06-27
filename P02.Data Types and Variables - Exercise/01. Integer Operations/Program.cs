using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            long sum = (long)firstNum + secondNum;
            long division = sum / thirdNum;
            long multiplication = division * fourthNum;

            Console.WriteLine(multiplication);
        }
    }
}
