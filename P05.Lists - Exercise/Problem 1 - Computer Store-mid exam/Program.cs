using System;

namespace Problem_1___Computer_Store_mid_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command=Console.ReadLine();
            double sum = 0;
           
            while (command != "regular" && command != "special")
            {
                double price = double.Parse(command);
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    command = Console.ReadLine();
                }
                else
                {
                    sum += price;
                    command = Console.ReadLine();
                }
               
            }
            double taxes = sum * 0.2;
            double totalSum = sum + taxes;
            if (totalSum == 0)
            {
                Console.WriteLine("Invalid order!");
            }
                else if (command == "special")
                {
                    totalSum = totalSum * 0.9;

                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {sum:f2}$");
                    Console.WriteLine($"Taxes: {taxes:f2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {totalSum:f2}$");
                }
                else if (command=="regular")
                {
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {sum:f2}$");
                    Console.WriteLine($"Taxes: {taxes:f2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {totalSum:f2}$");
                }
            
        }
    }
}

