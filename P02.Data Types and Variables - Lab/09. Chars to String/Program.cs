using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            char ch3 = char.Parse(Console.ReadLine());

            int sum = 0;

            int ch1Code = (int)ch1;
            int ch2Code = (int)ch2;
            int ch3Code = (int)ch3;

            sum = ch1Code + ch2Code + ch3Code;

          //  string str = sum.ToString();

            Console.WriteLine($"{sum.ToString()} "); 
        }
    }
}
