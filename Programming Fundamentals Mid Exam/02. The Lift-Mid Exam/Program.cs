﻿using System;
using System.Linq;

namespace _02._The_Lift_Mid_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine().Split().Select(int.Parse).ToArray();
           
            for (int i = 0; i < lift.Length; i++)
            {
                for (int j = lift[i]; j <= 4; j++)
                {
                    if (numOfPeople == 0 && lift[i] < 4)
                    {
                        Console.WriteLine("The lift has empty spots!");
                        Console.WriteLine(String.Join(" ", lift));
                    }
                    if (lift[i]==4)
                    {
                        break;
                    }
                    lift[i]++;
                    numOfPeople--;
                }
            }
            if (numOfPeople > 0)
            {
                Console.WriteLine($"There isn't enough space! {numOfPeople} people in a queue!");
                Console.WriteLine(String.Join(" ", lift));
            }
            else if (numOfPeople==0)
            {
                Console.WriteLine(String.Join(" ", lift));
            }
        }
    }
}

Every wagon should have a maximum of 4 people on it. If a wagon is full, you should direct the people to the next one with space available.
Input
•	On the first line, you will receive how many people are waiting to get on the lift
•	On the second line, you will receive the current state of the lift separated by a single space: " ".
Output
When there is no more available space left on the lift, or there are no more people in the queue, you should print on the console the final state of the lift's wagons separated by " " and one of the following messages:
•	If there are no more people and the lift have empty spots, you should print:
"The lift has empty spots!
{ wagons separated by ' '}
"
•	If there are still people in the queue and no more available space, you should print:
"There isn't enough space! {people} people in a queue!
{ wagons separated by ' '}
"
•	If the lift is full and there are no more people in the queue, you should print only the wagons separated by " "
