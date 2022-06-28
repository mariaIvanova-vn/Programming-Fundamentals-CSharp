using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (action == "add")
            {
                Add(num1, num2);
            }
            else if (action == "multiply")
            {
                Multiply(num1, num2);
            }
            else if (action == "subtract")
            {
                Subtract(num1, num2);
              
            }
            else 
            {
                Divide(num1, num2);
            }

        }
        static void Add(int num1,int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }
        static void Multiply(int num1, int num2)
        {
            Console.WriteLine(num1*num2);
        }
        static void Subtract(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }
        static void Divide(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }
    }
}
