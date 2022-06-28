using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            decimal result = (decimal)(FactorialSum(num1) / FactorialSum(num2));
            Console.WriteLine($"{result:f2}");
        }
        static double FactorialSum(int num)
        {
            if (num==1)
            {
                return 1;
            }
            else
            {
                return num * FactorialSum(num - 1);
            }
        }
    }
}
