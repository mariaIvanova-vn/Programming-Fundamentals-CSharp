using System;
using System.Collections.Generic;
using System.Linq;

namespace More_Exercise_01._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, List<string>> submissions = new Dictionary<string, List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] inputArgs = input.Split(':').ToArray();
                string name = inputArgs[0];
                string passForContest = inputArgs[1];
                if (!contests.ContainsKey(name))
                {
                    contests[name] = "";
                }
                contests[name] = passForContest;
            }
            string input2;
            while ((input2 = Console.ReadLine()) != "end of submissions")
            {
                string[] input2Args = input.Split("=>").ToArray();
                string contest = input2Args[0];
                string password = input2Args[1];
                string username = input2Args[2];
                string points = input2Args[3];
                if (!contests.ContainsKey(contest))
                {
                    break;
                }
                if (!contests.ContainsValue(password))
                {
                    break;
                }
                if (!submissions.ContainsKey(username))
                {
                    submissions.Add(username, new List<string>() { contest, points });
                }
                else
                {
                    submissions[username][0] = contest;
                    submissions[username][1] = points;
                }
            }
            //foreach (var item in contests)
            //{
            //    Console.WriteLine($"{item.Key}: {item.Value}");
            //}
            foreach (var item in submissions)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
