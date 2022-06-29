using System;
using System.Collections.Generic;
using System.Linq;

namespace More_Exercise_01._Company_Roster
{
    class Employee
    {
        public Employee(string name,decimal salary,string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>();
            List<string> departments = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string depertment = input[2];

                employee.Add(new Employee(name, salary, depertment));
                departments.Add(new string(depertment));
            }
            string departHightAvg = string.Empty;
            decimal hightAvgSalary = decimal.MinValue;
            foreach (string departmen in departments)
            {
                decimal avgSalary = employee.Where(s => s.Department == departmen).Select(s => s.Salary).Average();
                if (avgSalary>hightAvgSalary)
                {
                    hightAvgSalary = avgSalary;
                    departHightAvg = departmen;
                }
            }
            Console.WriteLine($"Highest Average Salary: {departHightAvg}");
            foreach (Employee employe in employee.Where(e=>e.Department==departHightAvg).OrderByDescending(e=>e.Salary))
            {
                Console.WriteLine($"{employe.Name} {employe.Salary:f2}");
            }
        }
    }
}
