using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;

            while (input!="Start")
            {
                double money = double.Parse(input);
                if (money == 0.1 || money == 0.2 || money == 0.5 || money == 1 || money == 2)
                {                   
                    sum += money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");                   
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input!="End")
            {
                double price = 0;
                if (input=="Nuts")
                {
                    price = 2.0;
                }
                else if (input=="Water")
                {
                    price = 0.7;
                }
                else if (input == "Crisps")
                {
                    price = 1.5;
                }
                else if (input == "Soda")
                {
                    price = 0.8;
                }
                else if (input == "Coke")
                {
                    price = 1.0;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                if (sum>=price && price>0)
                {
                    string productToLower = input.ToLower();
                    Console.WriteLine($"Purchased {productToLower}");
                    sum -= price;
                }
                else if(price>0)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}



