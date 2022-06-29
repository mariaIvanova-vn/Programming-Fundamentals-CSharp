using System;
using System.Collections.Generic;

namespace _04._Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string command = Console.ReadLine();
            while (command!="end")
            {
                string[] splitParams = command.Split();
                string firstName = splitParams[0];
                string lastName = splitParams[1];
                int age =int.Parse(splitParams[2]);
                string homeTown = splitParams[3];

                Student newStudent = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = homeTown
                };
                students.Add(newStudent);
                command = Console.ReadLine();
            }
            string homeTownToSearch = Console.ReadLine();
            List<Student> filteredStud = students.FindAll(student => student.HomeTown == homeTownToSearch);
            foreach (Student item in filteredStud)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
            }
        }
    }
}
