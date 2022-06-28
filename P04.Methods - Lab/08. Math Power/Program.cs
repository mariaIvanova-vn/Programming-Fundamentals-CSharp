using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double theBase = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            MathPower(theBase, power);
        }
        static void MathPower(double theBase,double power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result = result * theBase;
            }
            Console.WriteLine(result);
        }
    }
}
