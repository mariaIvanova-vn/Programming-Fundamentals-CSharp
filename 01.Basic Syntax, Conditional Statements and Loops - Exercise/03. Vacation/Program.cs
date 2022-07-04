using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 0;

            if (typeOfGroup== "Students"  && dayOfWeek== "Friday")
            {
                price = countOfPeople * 8.45;
                if (countOfPeople >= 30)
                {
                    price = price - (price * 0.15);
                }
            }
            else if (typeOfGroup == "Students" && dayOfWeek == "Saturday")
            {
                price = countOfPeople * 9.80;
                if (countOfPeople >= 30)
                {
                    price = price - (price * 0.15);
                }

            }
            else if (typeOfGroup == "Students" && dayOfWeek == "Sunday")
            {
                 price = countOfPeople * 10.46;
                if (countOfPeople >= 30)
                {
                    price = price - (price * 0.15);
                }
            }
            else if (typeOfGroup == "Business" && dayOfWeek == "Friday")
            {
                if (countOfPeople >= 100)
                {
                    price = (countOfPeople - 10) * 10.90;
                }
                else
                {
                    price = countOfPeople * 10.90;
                }              
            }
            else if (typeOfGroup == "Business" && dayOfWeek == "Saturday")
            {
                if (countOfPeople >= 100)
                {
                    price = (countOfPeople - 10) * 15.60;
                }
                else
                {
                    price = countOfPeople * 15.60;
                }              
            }
            else if (typeOfGroup == "Business" && dayOfWeek == "Sunday")
            {
                if (countOfPeople >= 100)
                {
                    price = (countOfPeople - 10) * 16;
                }
                else
                {
                    price = countOfPeople * 16;
                }              
            }
            else if (typeOfGroup == "Regular" && dayOfWeek == "Friday")
            {
                price = countOfPeople * 15;
            }
            else if (typeOfGroup == "Regular" && dayOfWeek == "Saturday")
            {
                price = countOfPeople * 20;
            }
            else if (typeOfGroup == "Regular" && dayOfWeek == "Sunday")
            {
                price = countOfPeople * 22.50;
            }
            if (typeOfGroup=="Regular" && countOfPeople>=10 && countOfPeople<=20)
            {
                price = price - (price * 0.05);
            }

            Console.WriteLine($"Total price: {price:f2}");           
        }
    }
}
