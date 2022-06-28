using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2___The_Lift_mid_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            List<int> finalLift = new List<int>();
            int finalLiftIndex = 0;

            for (int i = 0; i < lift.Length; i++)
            {
                int currWagon = lift[i];
                if (currWagon<4)
                {
                    currWagon += 4 - currWagon;
                    numOfPeople -= 4 - currWagon;
                }

                finalLift[finalLiftIndex] = currWagon;
                finalLiftIndex++;
               
                //if (numOfPeople > 0 &&  currWagon==4)
                //{
                //    Console.WriteLine($"There isn't enough space! {numOfPeople} people in a queue!");
                //    Console.WriteLine(String.Join(" ", finalLift));
                //}
            }
            if (finalLift.FindIndex(x => x<4))
            {
               Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(String.Join(" ", finalLift));
            }

            Console.WriteLine(string.Join(" ",finalLift));
        }
    }   
}


