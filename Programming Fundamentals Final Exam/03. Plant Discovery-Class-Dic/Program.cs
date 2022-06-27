using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery_Class_Dic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> plants = new Dictionary<string, int>();
            Dictionary<string, List<double>> plantsRating = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string plant = input[0];
                int rarity = int.Parse(input[1]);
                plants[plant] = rarity;
            }
            string command;
            while ((command = Console.ReadLine()) != "Exhibition")
            {
                string[] cmdArgs = command.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];
                string[] cmdArgs2 = cmdArgs[1].Split(" - ");
                string plant = cmdArgs2[0];
                if (cmdType== "Rate")
                {
                    int rating = int.Parse(cmdArgs2[1]);
                    if (!plants.ContainsKey(plant))
                    {
                        Console.WriteLine("error");
                    }
                    if (!plantsRating.ContainsKey(plant))
                    {
                        plantsRating[plant] = new List<double>();
                    }
                    plantsRating[plant].Add(rating);
                    
                }
                else if (cmdType== "Update")
                {
                    int newRarity = int.Parse(cmdArgs2[1]);
                    if (!plants.ContainsKey(plant))
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        plants[plant] = newRarity;
                    } 
                }
                else if (cmdType== "Reset")
                {
                    if (!plants.ContainsKey(plant))
                    {
                        Console.WriteLine("error");
                    }
                    if (plantsRating.ContainsKey(plant))
                    {
                        plantsRating[plant].Clear();
                    }
                }
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in plants)
            {
                var currPlant = item.Key;
                var currRarity = item.Value;
                double avgRating = 0;
                if (plantsRating.ContainsKey(currPlant) && plantsRating[currPlant].Any())
                {
                    avgRating = plantsRating[currPlant].Average();
                }
                Console.WriteLine($"- {currPlant}; Rarity: {currRarity}; Rating: {avgRating:f2}");
            }
        }
    }
}
