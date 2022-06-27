using System;

namespace _01._Counter_Strike_Mid_Exam     //    100 / 100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            int count = 0;
            
                string command;
            while ((command = Console.ReadLine()) != "End of battle" )
            {
                int distance = int.Parse(command);
                if (initialEnergy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {count} won battles and {initialEnergy} energy");
                    return;
                }
                count++;              
                initialEnergy -= distance;
                if (count%3==0)
                {
                    initialEnergy += count;
                }
            }
                Console.WriteLine($"Won battles: {count}. Energy left: {initialEnergy}");           
        }
    }
}
