using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public Vehicle(string type,string model,string color,int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsePower;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double carsHorsePower = 0;
            int carCount = 0;
            double trucksHorsePower = 0;
            int truckCount = 0;

            List<Vehicle> vechicles = new List<Vehicle>();
            List<string> brands = new List<string>();
            List<string> checkBrands = new List<string>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArg = command.Split().ToArray();
                string typeOfVehicle = cmdArg[0];
                string model = cmdArg[1];
                string color = cmdArg[2];
                int horsepower = int.Parse(cmdArg[3]);
                if (truckCount==0)
                {
                    trucksHorsePower = 0;
                }
                if (checkBrands.Contains(model))
                {
                    continue;
                }
                Vehicle vehicle = new Vehicle(typeOfVehicle, model, color,horsepower);
                if (typeOfVehicle == "car")
                {
                    carsHorsePower += horsepower;

                    carCount++;

                    vechicles.Add(vehicle);
                }
                else if (typeOfVehicle == "truck")
                {
                    trucksHorsePower += horsepower;

                    truckCount++;

                    vechicles.Add(vehicle);
                }
                checkBrands.Add(model);
            }
            command = Console.ReadLine();
            while (command != "Close the Catalogue")
            {
                brands.Add(command);
                command = Console.ReadLine();
            }
            
            for (int i = 0; i < brands.Count; i++)
            {
                foreach (Vehicle vehicle in vechicles)
                {
                    if (brands[i] == vehicle.Model)
                    {
                        Console.WriteLine($"Type: {System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(vehicle.Type.ToLower())}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
                       
                    }
                }
            }
            if (carCount>0)
            {
                Console.WriteLine($"Cars have average horsepower of: {carsHorsePower / carCount:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            if (truckCount>0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {trucksHorsePower / truckCount:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }   
    }
}
