using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingRegister = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split().ToArray();
                string cmdType = cmdArgs[0];
                string userName = cmdArgs[1];
                if (cmdType == "register")
                {
                    string licensePlateNum = cmdArgs[2];
                    RegisterUser(parkingRegister, userName, licensePlateNum);
                }
                else if (cmdType== "unregister")
                {
                    UnRegisterUser(parkingRegister, userName);
                }               
            }
            foreach (var kvp in parkingRegister)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
        static void RegisterUser(Dictionary<string,string> parkingRegister,string userName,string licensePlateNum)
        {
            if (parkingRegister.ContainsKey(userName))
            {
                string licenseNumReg = parkingRegister[userName];
                Console.WriteLine($"ERROR: already registered with plate number {licenseNumReg}");
            }
            else
            {
                parkingRegister[userName] = licensePlateNum;
                Console.WriteLine($"{userName} registered {licensePlateNum} successfully");
            }
        }
        static void UnRegisterUser(Dictionary<string, string> parkingRegister, string userName)
        {
            if (!parkingRegister.ContainsKey(userName))
            {
                Console.WriteLine($"ERROR: user {userName} not found");
            }
            else
            {
                parkingRegister.Remove(userName);
                Console.WriteLine($"{userName} unregistered successfully");
            }
        }
    }
}
