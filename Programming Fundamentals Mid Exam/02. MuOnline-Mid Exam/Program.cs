using System;
using System.Collections.Generic;
using System.Linq;


namespace _02._MuOnline_Mid_Exam                  //100 / 100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split("|").ToArray();
            int health = 100;
            int bitcoins = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {                
                string[] currArray = array[i].Split();
                string command = currArray[0];
                int number = int.Parse(currArray[1]);
                if (command== "potion")
                {
                    count++;
                    int pastHealth = health;
                    health += number;
                    if (health > 100) health = 100;
                    int hp = health - pastHealth;
                    if (pastHealth == 100) hp = 0;

                        Console.WriteLine($"You healed for {hp} hp.");
                        Console.WriteLine($"Current health: {health} hp.");                                   
                }
                else if (command== "chest")
                {
                    count++;
                    bitcoins += number;
                    Console.WriteLine($"You found {number} bitcoins.");
                }
                else
                {
                    count++;
                    health -= number;
                    if (health>0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else 
                    {     
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {count}");
                        return;
                    }
                }               
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}



