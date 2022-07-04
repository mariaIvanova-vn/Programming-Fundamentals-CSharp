using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyOfJohn = double.Parse(Console.ReadLine());
            int countOfStudent = int.Parse(Console.ReadLine());
            double singlePriceOfLightsabers = double.Parse(Console.ReadLine());
            double singlePriceOfRobes = double.Parse(Console.ReadLine());
            double singlePriceOfBelt = double.Parse(Console.ReadLine());

            int count = 0;
            if (countOfStudent>=6)
            {
                count=countOfStudent/6;
            }           
            double sum = (singlePriceOfLightsabers * Math.Ceiling(countOfStudent* 1.1)) + (singlePriceOfRobes * countOfStudent) + (singlePriceOfBelt * (countOfStudent - count));
            if (sum<=moneyOfJohn)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(sum - moneyOfJohn):f2}lv more.");
            }
        }
    }
}
