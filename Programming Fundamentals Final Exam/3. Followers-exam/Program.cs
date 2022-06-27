using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Followers_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> followers = new Dictionary<string, int>();


            string command;
            while ((command = Console.ReadLine()) != "Log out")
            {
                string[] cmdArgs = command.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];
                if (cmdType== "New follower")
                {
                    string username = cmdArgs[1];
                    if (!followers.ContainsKey(username))
                    {
                        followers[username] = 0;                      
                    }
                }
                else if (cmdType== "Like")
                {
                    string username = cmdArgs[1];
                    int count = int.Parse(cmdArgs[2]);
                    if (!followers.ContainsKey(username))
                    {
                        followers[username]=count;
                    }
                    else
                    {
                        followers[username] += count;
                        
                    }
                }
                else if (cmdType== "Comment")
                {
                    string username = cmdArgs[1];
                    if (!followers.ContainsKey(username))
                    {
                        followers[username] = 1;
                    }
                    else
                    {
                        followers[username] += 1;
                    }
                }
                else if (cmdType== "Blocked")
                {
                    string username = cmdArgs[1];
                    if (followers.ContainsKey(username))
                    {
                        
                        followers.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                    }
                }
            }
            Console.WriteLine($"{followers.Count} followers");
            foreach (var item in followers)
            {
 
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
