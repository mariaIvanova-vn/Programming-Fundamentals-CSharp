using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tank = 250;
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int quantities = int.Parse(Console.ReadLine());
                
                if (sum+quantities > tank)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum += quantities;                  
                }
            }
            Console.WriteLine(sum);
        }
    }
}
