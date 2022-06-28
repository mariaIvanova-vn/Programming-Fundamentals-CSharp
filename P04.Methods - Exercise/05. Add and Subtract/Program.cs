using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int getSub = GetSubstract(num1, num2, num3);
            Console.WriteLine(getSub);
        }
        static int GetSum(int num1,int num2)
        {
            return num1 + num2;
        }
        static int GetSubstract(int num1,int num2, int num3)
        {
            return GetSum(num1,num2) - num3;
        }
    }
}
