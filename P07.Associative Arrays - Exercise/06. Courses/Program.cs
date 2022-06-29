using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseInfo = new Dictionary<string, List<string>>();
            string command;
            while ((command=Console.ReadLine())!="end")
            {
                string[] courseArgs = command.Split(" : ").ToArray();
                string courseName = courseArgs[0];
                string studentName = courseArgs[1];
                if (!courseInfo.ContainsKey(courseName))
                {
                    courseInfo[courseName] = new List<string>();
                }
                courseInfo[courseName].Add(studentName);
            }
            foreach (var kvp in courseInfo)
            {
                Console.WriteLine($"{kvp.Key}: {(kvp.Value).Count}");
                foreach (var stud in kvp.Value)
                {
                    Console.WriteLine($"-- {stud}");
                }
            }
        }
    }
}
