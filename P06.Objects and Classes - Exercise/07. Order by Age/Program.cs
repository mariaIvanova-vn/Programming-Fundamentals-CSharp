using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Order
    {
        public Order(string name,string id,int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{this.Name} with ID: {this.ID} is {this.Age} years old.";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command.Split().ToArray();
                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);

                Order currOrder = new Order(name, id, age);
                orders.Add(currOrder);
            }
            orders = orders.OrderBy(o => o.Age).ToList();
            foreach (Order item in orders)
            {
                Console.WriteLine(item);
            }
        }
    }
}
