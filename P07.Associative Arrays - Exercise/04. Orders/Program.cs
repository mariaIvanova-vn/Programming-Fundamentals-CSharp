using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> order = new Dictionary<string, List<double>>();         
            string command;
            while ((command = Console.ReadLine()) != "buy")
            {
                string[] commandArgs = command.Split().ToArray();
                string name = commandArgs[0];
                double price = double.Parse(commandArgs[1]);
                double quantity = double.Parse(commandArgs[2]);
                if (!order.ContainsKey(name))
                {
                    order.Add(name, new List<double>() { price, quantity });
                }
                else
                {
                    order[name][0] = price;
                    order[name][1] += quantity;
                }               
            }
            foreach (var items in order)
            {
                Console.WriteLine($"{items.Key} -> {(items.Value[0] * items.Value[1]):f2}");
            }            
        }
    }
}
