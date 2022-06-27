using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII___dic_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                string heroName = input[0];
                int hp = int.Parse(input[1]);
                int mp = int.Parse(input[2]);
                if (!heroes.ContainsKey(heroName))
                {
                    heroes.Add(heroName, new List<int>() { hp, mp, 0 });
                }
                    
            }
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];
                string heroName = cmdArgs[1];
                if (cmdType == "CastSpell")
                {
                    int mpNeeded = int.Parse(cmdArgs[2]);
                    string spellName = cmdArgs[3];
                    if (heroes[heroName][1]<mpNeeded)
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                    else
                    {
                        heroes[heroName][1] -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName][1]} MP!");
                    }
                }
                else if (cmdType == "TakeDamage")
                {
                    int damage = int.Parse(cmdArgs[2]);
                    string attacker = cmdArgs[3];
                    heroes[heroName][0] -= damage;
                    if (heroes[heroName][0] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName][0]} HP left!");
                    }
                    else
                    {
                        heroes.Remove(heroName);
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }
                else if (cmdType == "Recharge")
                {
                    int amount = int.Parse(cmdArgs[2]);
                    int originalMP = heroes[heroName][1];
                    heroes[heroName][1] += amount;
                    if (heroes[heroName][1] > 200)
                    {
                        heroes[heroName][1] = 200;
                        Console.WriteLine($"{heroName} recharged for {200 - originalMP} MP!");       
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} recharged for {heroes[heroName][1] - originalMP} MP!");
                    }
                }
                else if (cmdType == "Heal")
                {
                    int amount = int.Parse(cmdArgs[2]);
                    int originalHP = heroes[heroName][0];
                    heroes[heroName][0] += amount;                   
                    if (heroes[heroName][0] > 100)
                    {
                        heroes[heroName][0] = 100;
                        Console.WriteLine($"{heroName} healed for {100 - originalHP} HP!");                      
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} healed for {heroes[heroName][0] - originalHP} HP!");
                    }
                }
            }
            foreach (var item in heroes)
            {
                
                if (item.Value[0]>0 && item.Value[1]>0)
                {
                    Console.WriteLine($"{item.Key}");
                    Console.WriteLine($"  HP: {item.Value[0]}");
                    Console.WriteLine($"  MP: {item.Value[1]}");
                }
            }
        }
    }
}
