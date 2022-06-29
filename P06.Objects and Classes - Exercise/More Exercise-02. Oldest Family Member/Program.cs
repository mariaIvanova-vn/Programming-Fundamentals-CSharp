using System;
using System.Collections.Generic;
using System.Linq;

namespace More_Exercise_02._Oldest_Family_Member
{
    class Family
    {
        public Family()
        {
            this.People = new List<Person>();
        }
        public List<Person> People { get; set; }
        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public void GetOldestMember()
        {
            Person oldestPerson = People.OrderByDescending(x => x.Age).FirstOrDefault();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
    class Person
    {
        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           // List<Family> family = new List<Family>();
            int n = int.Parse(Console.ReadLine());
            var currentFamily = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string name = input[0];
                int age = int.Parse(input[1]);
                var member = new Person(name,age);

                currentFamily.AddMember(member);
            }
            if (currentFamily.People.Count > 0)
            {
                currentFamily.GetOldestMember();               
            }
        }
    }
}
