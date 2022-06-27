
using System;
using System.Linq;

namespace _1._Password_Validator__exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Complete")
            {
                string[] cmdArgs = command.Split();
                string cmdType = cmdArgs[0];
                
                if (cmdType == "Make")
                {
                    int index = int.Parse(cmdArgs[2]);
                    string currCommand = cmdArgs[1];
                    if (currCommand== "Upper")
                    {
                        char currCh = password[index];
                        password = password.Remove(index,1);
                        password = password.Insert(index, currCh.ToString().ToUpper());
                        Console.WriteLine(password);
                    }
                    else if (currCommand == "Lower")
                    {                       
                        char currCh = password[index]; 
                        password = password.Remove(index,1);
                        password = password.Insert(index, currCh.ToString().ToLower());
                        Console.WriteLine(password);
                    }
                }              
                else if (cmdType == "Insert")
                {
                    int index = int.Parse(cmdArgs[1]);
                    char currChar = char.Parse(cmdArgs[2]);
                    if (index>=0 && index<password.Length)
                    {
                        password = password.Insert(index, currChar.ToString());
                        Console.WriteLine(password);
                    }
                }
                else if (cmdType == "Replace")
                {
                    char currChar = char.Parse(cmdArgs[1]);
                    int value = int.Parse(cmdArgs[2]);
                    if (password.Contains(currChar))
                    {
                        int currCharValue = (int)currChar;
                        value += currCharValue;
                        char newChar = (char)value;
                        password = password.Replace(currChar, newChar);
                        Console.WriteLine(password);
                    }
                }
                else if (cmdType == "Validation")
                {
                    if (password.Length<8)
                    {
                        Console.WriteLine("Password must be at least 8 characters long!");
                    }
                    else if (!password.Any(x => char.IsDigit(x)))
                    {
                        Console.WriteLine("Password must consist at least one digit!");
                    }
                 else    if (!password.Any(x => char.IsDigit(x)) && password.Contains('_'))
                    {
                        Console.WriteLine("Password must consist only of letters, digits and _!");
                    }
                 else   if (!password.Any(x => char.IsUpper(x)))
                    {
                        Console.WriteLine("Password must consist at least one uppercase letter!");
                    }
                  else  if (!password.Any(x => char.IsLower(x)))
                    {
                        Console.WriteLine("Password must consist at least one lowercase letter!");
                    }                    
                }
            }
        }
    }
}
