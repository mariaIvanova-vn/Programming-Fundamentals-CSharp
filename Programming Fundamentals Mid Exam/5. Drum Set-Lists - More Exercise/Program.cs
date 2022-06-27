using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Drum_Set_Lists___More_Exercise        //  100/100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> dublicate = new List<int>();      //pravq nov prazen list
            dublicate.AddRange(numbers);                 // pulnq go s elementite ot numbers (stava dublikat na purviq) 
            
            string command;
            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {                
                int power = int.Parse(command);

                for (int k = 0; k < numbers.Count; k++)
                {
                    numbers[k] -= power;
                    if (numbers[k] <= 0)
                    {
                        if (savings - (dublicate[k] * 3) >= 0)
                        {
                            savings = savings - (dublicate[k] * 3);
                            numbers[k] = dublicate[k];
                        }
                    }
                }
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i]<=0)
                    {
                        numbers.RemoveAt(i);
                        dublicate.RemoveAt(i);
                    }
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
