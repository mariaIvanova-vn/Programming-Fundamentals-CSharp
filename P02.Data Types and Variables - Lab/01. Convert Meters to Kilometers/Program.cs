using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            decimal kilometers = (decimal)(meters / 1000.0f); 

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
