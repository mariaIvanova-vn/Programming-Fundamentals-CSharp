using System;

namespace _01._The_Hunting_Games
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int numberOfPlayers = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterPerDayForOnePerson = double.Parse(Console.ReadLine());
            double foodPerDayForOnePerson = double.Parse(Console.ReadLine());

           
            double totalWater = (days * numberOfPlayers * waterPerDayForOnePerson);
            double totalFood = (days * numberOfPlayers * foodPerDayForOnePerson);


            for (int i = 1; i <= days; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                groupEnergy -= energyLoss;
                if (groupEnergy <= 0)
                {
                    break;
                }
                
                if (i%2==0)
                {
                    totalWater -= totalWater * 0.3;
                    groupEnergy += groupEnergy * 0.05;
                }
                if (i%3==0)
                {
                    totalFood -= (totalFood / numberOfPlayers);
                    groupEnergy += groupEnergy * 0.1;
                }
            }

            if (groupEnergy>0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
            }
        }
    }
}
