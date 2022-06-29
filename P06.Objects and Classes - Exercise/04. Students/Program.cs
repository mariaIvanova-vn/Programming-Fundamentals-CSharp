using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Student
    {
        public Student(string firstName,string lastName,double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
       
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] studArg = Console.ReadLine().Split().ToArray();
                string currStudFirstName = studArg[0];
                string currStudLastName = studArg[1];
                double currStudGrade = double.Parse(studArg[2]);

                Student currStudent = new Student(currStudFirstName, currStudLastName, currStudGrade);
                students.Add(currStudent);
            }
            students = students.OrderByDescending(s => s.Grade).ToList();
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
         }
    }
}
