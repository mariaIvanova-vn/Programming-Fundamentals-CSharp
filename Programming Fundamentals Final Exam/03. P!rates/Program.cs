using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Cityes> cities = new Dictionary<string, Cityes>();
            string firstCommand;
            while ((firstCommand = Console.ReadLine()) != "Sail")
            {
                string[] firstCmdArgs = firstCommand.Split("||", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string city = firstCmdArgs[0];
                int population = int.Parse(firstCmdArgs[1]);
                int gold = int.Parse(firstCmdArgs[2]);
                if (!cities.ContainsKey(city))
                {
                    Cityes currCity = new Cityes(city, population, gold);
                    cities.Add(city, currCity);
                }
                else
                {
                    cities[city].Population += population;
                    cities[city].Gold += gold;
                }
            }
            string secondCommand;
            while ((secondCommand = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = secondCommand.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];
                string town = cmdArgs[1];
                if (cmdType== "Plunder")
                {
                    int people = int.Parse(cmdArgs[2]);
                    int gold = int.Parse(cmdArgs[3]);
                    cities[town].Population -= people;
                    cities[town].Gold -= gold;
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                    if (cities[town].Population<=0 || cities[town].Gold<=0)
                    {
                        cities.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }                      
                }
                else if (cmdType== "Prosper")
                {
                    int gold = int.Parse(cmdArgs[2]);
                    if (gold<0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        cities[town].Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town].Gold} gold.");
                    }
                }
            }
            if (cities.Count>0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var item in cities)
                {
                    Cityes currCity = item.Value;
                    Console.WriteLine($"{currCity.City} -> Population: {currCity.Population} citizens, Gold: {currCity.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            } 
        }
    }
    class Cityes
    {
        public Cityes(string city, int population, int gold)
        {
            this.City = city;
            this.Population = population;
            this.Gold = gold;
        }
        public string City { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
}
