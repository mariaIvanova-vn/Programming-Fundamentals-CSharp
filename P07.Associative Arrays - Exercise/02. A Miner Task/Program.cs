using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string resourceCmd;
            while ((resourceCmd=Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(resourceCmd))
                {
                    resources[resourceCmd] += quantity;
                }
                else
                {
                    resources.Add(resourceCmd, quantity);
                }
            }
            foreach (var rqp in resources)
            {
                Console.WriteLine($"{rqp.Key} -> {rqp.Value}");
            }
         }
    }
}
