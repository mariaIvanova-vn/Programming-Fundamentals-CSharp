using System;

namespace _05._Orders
{
    internal class ProgramBase
    {

        private static string Orders(string product, int quantity)
        {
            double sum = 0;

            if (product == "coffee")
            {
                sum = quantity * 1.50;
                Console.WriteLine(sum);
            }
            else if (product == "water")
            {
                sum = quantity * 1.00;
            }
        }
    }
}