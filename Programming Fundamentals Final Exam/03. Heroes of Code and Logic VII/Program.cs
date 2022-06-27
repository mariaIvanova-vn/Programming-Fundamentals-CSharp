using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII         // 100 / 100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();

           int  maxHP = 100;
           int maxMP = 200;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string heroName = input[0];
                int hp = int.Parse(input[1]);
                int mp = int.Parse(input[2]);
                Hero currHero = new Hero(heroName, hp, mp);
                heroes.Add(heroName, currHero);
            }
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];
                string heroName = cmdArgs[1];
                if (cmdType== "CastSpell")
                {
                    int mpNeeded = int.Parse(cmdArgs[2]);
                    string spellName = cmdArgs[3];
                    if (heroes[heroName].MP>=mpNeeded)
                    {
                        heroes[heroName].MP -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName].MP} MP!");                      
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (cmdType== "TakeDamage")
                {
                    int damage = int.Parse(cmdArgs[2]);
                    string attacker = cmdArgs[3];
                    heroes[heroName].HP -= damage;
                    if (heroes[heroName].HP>0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName].HP} HP left!");
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
                    int originalMP = heroes[heroName].MP;
                    heroes[heroName].MP += amount;
                    if (heroes[heroName].MP> maxMP)
                    {
                        heroes[heroName].MP = maxMP;
                        Console.WriteLine($"{heroName} recharged for {maxMP-originalMP} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                    } 
                }
                else if (cmdType == "Heal")
                {
                    int amount = int.Parse(cmdArgs[2]);
                    int originalHP = heroes[heroName].HP;
                    heroes[heroName].HP += amount;
                    if (heroes[heroName].HP > maxHP)
                    {
                        heroes[heroName].HP = maxHP;
                        Console.WriteLine($"{heroName} healed for {maxHP-originalHP} HP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                    }                   
                }
            }
            foreach (var item in heroes)
            {
                Hero currHero = item.Value;
               // if (currHero.HP>0 && currHero.MP>0)
              //  {
                    Console.WriteLine($"{currHero.HeroName}");
                    Console.WriteLine($"  HP: {currHero.HP}");
                    Console.WriteLine($"  MP: {currHero.MP}");
               // }    
            }
        }
    }
    class Hero
    {
        public Hero(string heroName, int hp, int mp)
        {
            this.HeroName = heroName;
            this.HP = hp;
            this.MP = mp;
        }
        public string HeroName { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
    }
}
