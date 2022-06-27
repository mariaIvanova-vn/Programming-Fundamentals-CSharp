using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            var pounds = double.Parse(Console.ReadLine());
            decimal usd = (decimal)(pounds * 1.31);
            Console.WriteLine($"{usd:f3}");
        }
    }
}
