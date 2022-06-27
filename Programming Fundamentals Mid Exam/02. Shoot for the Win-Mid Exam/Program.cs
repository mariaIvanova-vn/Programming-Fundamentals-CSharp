using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shoot_for_the_Win_Mid_Exam         //100/100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;
           
            string command="";
            while ((command = Console.ReadLine()) != "End")
            {
                int indexOfTheTargetToBeShot = int.Parse(command);

                if (indexOfTheTargetToBeShot>=0 && indexOfTheTargetToBeShot<numbers.Length)
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        int currIndex = numbers[indexOfTheTargetToBeShot];
                        if (numbers[i]!=-1 && i!=indexOfTheTargetToBeShot)
                        {
                            if (numbers[i]>currIndex)
                            {
                                numbers[i] -= currIndex;
                            }else if (numbers[i] <= currIndex)
                            {
                                numbers[i] += currIndex;
                            }
                        }
                    }
                    numbers[indexOfTheTargetToBeShot] = -1;
                    count++;
                }
            }
            Console.WriteLine($"Shot targets: {count} -> {string.Join(" ",numbers)}");
        }
    }
}

//Write a program that helps you keep track of your shot targets. You will receive a sequence with integers, separated by a single space, representing targets and their value. Afterward, you will be receiving indices until the "End" command is given, and you need to print the targets and the count of shot targets.
//Every time you receive an index, you need to shoot the target on that index, if it is possible. 
//Every time you shoot a target, its value becomes -1, and it is considered shot. Along with that, you also need to:
//•	Reduce all the other targets, which have greater values than your current target, with its value. 
//•	Increase all the other targets, which have less than or equal value to the shot target, with its value.

//Keep in mind that you can't shoot a target, which is already shot. You also can't increase or reduce a target, which is considered shot.
//When you receive the "End" command, print the targets in their current state and the count of shot targets in the following format:
//"Shot targets: {count} -> {target1} {target2}… {targetn}"

//Input / Constraints
//•	On the first line of input, you will receive a sequence of integers, separated by a single space – the targets sequence.
//•	On the following lines, until the "End" command, you be receiving integers each on a single line – the index of the target to be shot.
