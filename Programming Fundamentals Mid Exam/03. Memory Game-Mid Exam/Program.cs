using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game_Mid_Exam            // 100 / 100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sequenceOfElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            int count = 0;

            string command;
            while ((command = Console.ReadLine()) != "end" && sequenceOfElements.Count != 0)
            {
                int[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                count++;
                int left = cmdArgs[0];
                int right = cmdArgs[1];
                
                if (!(left == right || left < 0 || left >= sequenceOfElements.Count || right < 0 || right >= sequenceOfElements.Count))
                {
                    if (sequenceOfElements[left] == sequenceOfElements[right])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {sequenceOfElements[left]}!");
                        if (left > right)
                        {
                            sequenceOfElements.RemoveAt(left);
                            sequenceOfElements.RemoveAt(right);
                            if (sequenceOfElements.Count==0)
                            {
                                break;
                            }
                        }
                        else
                        {
                            sequenceOfElements.RemoveAt(right);
                            sequenceOfElements.RemoveAt(left); 
                            if (sequenceOfElements.Count == 0)
                            {
                                break;
                            }
                        }
                    }
                    else      {    Console.WriteLine("Try again!");    }
                }
              else  
              {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    sequenceOfElements.Insert(sequenceOfElements.Count / 2, $"-{count}a");
                    sequenceOfElements.Insert(sequenceOfElements.Count / 2, $"-{count}a");
              }
            }
            if (command!="end")
            {
                Console.WriteLine($"You have won in {count} turns!"); 
            }
            else 
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(String.Join(" ", sequenceOfElements));
            }
        }
    }
}
Write a program that recreates the Memory game.
On the first line, you will receive a sequence of elements. Each element in the sequence will have a twin. Until the player receives "end" from the console, you will receive strings with two integers separated by a space, representing the indexes of elements in the sequence.
If the player tries to cheat and enters two equal indexes or indexes which are out of bounds of the sequence, you should add two matching elements at the middle of the sequence in the following format:
"-{number of moves until now}a"
Then print this message on the console:
"Invalid input! Adding additional elements to the board"
Input
•	On the first line, you will receive a sequence of elements
•	On the following lines, you will receive integers until the command "end"
Output
•	Every time the player hit two matching elements, you should remove them from the sequence and print on the console the following message:
"Congrats! You have found matching elements - ${element}!"
•	If the player hit two different elements, you should print on the console the following message:
"Try again!"
•	If the player hit all matching elements before he receives "end" from the console, you should print on the console the following message: 
"You have won in {number of moves until now} turns!"
•	If the player receives "end" before he hits all matching elements, you should print on the console the following message:
"Sorry you lose :(
{ the current sequence's state}"
