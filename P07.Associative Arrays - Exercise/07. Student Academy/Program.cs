using System;
using System.Collections.Generic;

namespace _07._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                int count = 1;
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());                
                if (students.ContainsKey(name))
                {
                    count++;
                    students[name] += grade;
                    students[name] /= count;
                }
                else
                {
                    students.Add(name, grade);                   
                }
            }
            foreach (var student in students)
            {
                if (student.Value >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value:f2}");
                }
            }
        }
    }
}
