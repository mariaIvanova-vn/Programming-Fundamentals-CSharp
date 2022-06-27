using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> plant = new Dictionary<string, int>();
            Dictionary<string, List<double>> plantRatings = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string plantName = input[0];
                int plantRarity = int.Parse(input[1]);

                plant[plantName] = plantRarity;    //add plantName i plantRarity
            }
            string command;
            while ((command = Console.ReadLine()) != "Exhibition")
            {
                string[] cmdArgs = command.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];

                string[] argss = cmdArgs[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string plantName = argss[0];

                if (cmdType== "Rate")
                {
                    double plantRating = double.Parse(argss[1]);
                    if (!plant.ContainsKey(plantName))
                    {
                        Console.WriteLine("error");
                    }
                    if (!plantRatings.ContainsKey(plantName))
                    {
                        plantRatings[plantName] = new List<double>();
                    }
                    plantRatings[plantName].Add(plantRating);
                }
                else if (cmdType== "Update")
                {
                    int newR = int.Parse(argss[1]);
                    if (plant.ContainsKey(plantName))
                    {
                        plant[plantName] = newR;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmdType == "Reset")
                {
                    if (!plant.ContainsKey(plantName))
                    {
                        Console.WriteLine("error");                   
                    }
                    if (plantRatings.ContainsKey(plantName))
                    {
                        plantRatings[plantName].Clear();
                    }
                }
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in plant)
            {
                string plantName = item.Key;
                int rarity = item.Value;
                double avgRating = 0;
                if (plantRatings.ContainsKey(plantName) && plantRatings[plantName].Any())
                {
                    avgRating = plantRatings[plantName].Average();
                }
                Console.WriteLine($"- {plantName}; Rarity: {rarity}; Rating: {avgRating:f2}");
            }
        }
    }
}
