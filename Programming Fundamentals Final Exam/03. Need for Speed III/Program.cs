using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Cars> cars = new Dictionary<string, Cars>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string car = input[0];
                int currMileage =int.Parse( input[1]);
                int currFuel = int.Parse( input[2]);

                Cars currCar = new Cars(car, currMileage, currFuel);
                cars.Add(car, currCar);
            }
            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] cmdArgs = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];
              //  string car = cmdArgs[1];
                if (cmdType == "Drive")
                {
                    string currCar = cmdArgs[1];
                    int distance = int.Parse(cmdArgs[2]);
                    int fuel = int.Parse(cmdArgs[3]);
                    if (cars.ContainsKey(currCar))
                    {                                            
                        if (cars[currCar].Fuel < fuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            cars[currCar].Mileage += distance;
                            cars[currCar].Fuel -= fuel;
                            Console.WriteLine($"{currCar} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        }
                    }
                    if (cars[currCar].Mileage>=100000)
                    {
                        cars.Remove(currCar);
                        Console.WriteLine($"Time to sell the {currCar}!");
                    }
                }
                else if(cmdType== "Refuel")
                {
                    string currCar = cmdArgs[1];
                    int fuel = int.Parse(cmdArgs[2]);

                    int originalFuel = cars[currCar].Fuel;
                    int currFuel = 75 - originalFuel;
                    cars[currCar].Fuel += fuel;
                   
                    if (cars[currCar].Fuel>75)
                    {
                        cars[currCar].Fuel = 75;
                        Console.WriteLine($"{currCar} refueled with {currFuel} liters");
                    }
                    else
                    {
                        Console.WriteLine($"{currCar} refueled with {fuel} liters");
                    }                    
                }
                else if (cmdType == "Revert")
                {
                    string currCar = cmdArgs[1];
                    int kilometers = int.Parse(cmdArgs[2]);
                    cars[currCar].Mileage -= kilometers;
                    if (cars[currCar].Mileage<10000)
                    {
                        cars[currCar].Mileage = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{currCar} mileage decreased by {kilometers} kilometers");
                    }
                }
            }
            foreach (var item in cars)
            {
                Cars currCar = item.Value;
                Console.WriteLine($"{currCar.Car} -> Mileage: {currCar.Mileage} kms, Fuel in the tank: {currCar.Fuel} lt.");
            }
        }
    }
    class Cars
    {
        public Cars(string car, int mileage, int fuel)
        {
            this.Car = car;
            this.Mileage = mileage;
            this.Fuel = fuel;
        }
        public string Car { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
}
