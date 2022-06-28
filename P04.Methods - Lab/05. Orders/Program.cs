using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
          Orders(product, n); 

        }

        static void Orders(string product, int quantity)
        {
            double sum = 0;
          //  string result = "";

            if (product=="coffee")
            {
                sum = quantity * 1.50;
              //  result += sum;
            }
            else if (product=="water")
            {
                sum = quantity * 1.00;
              //  result += sum;
            }
            else if (product == "coke")
            {
                sum = quantity * 1.40;
              //  result += sum;
            }
            else if (product == "snacks")
            {
                sum = quantity * 2.00;
               // result += sum;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
