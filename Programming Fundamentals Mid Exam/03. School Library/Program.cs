using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._School_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine().Split("&").ToList();
            string command;
            while ((command = Console.ReadLine()) != "Done")
            {
                List<string> cmdArgs = command.Split(" | ").ToList();
                string cmdType = cmdArgs[0];
                string bookName = cmdArgs[1];

                string[] typeOf = cmdType.Split().ToArray();
                string type = typeOf[0];

                if (type == "Add")
                {
                    if (!books.Contains(bookName))
                    {
                        books.Insert(0, bookName);
                    }
                }
                else if (type == "Take")
                {
                    if (books.Contains(bookName))
                    {
                        books.Remove(bookName);
                    }
                }
                else if (type == "Swap")
                {
                    string book1 = cmdArgs[1];
                    string book2 = cmdArgs[2];
                    if (books.Contains(book1) && books.Contains(book2))
                    {
                        string temp1 = book1;
                        string temp2 = book2;
                        int indexOfFirstBook = books.IndexOf(book1);
                        int indexOfSecondBook = books.IndexOf(book2);
                        
                        if (indexOfFirstBook>indexOfSecondBook)
                        {
                            
                            books.Remove(book1);
                            books.Remove(book2);
                        }
                        else
                        {
                            
                            books.Remove(book2);
                            books.Remove(book1);
                        }
                        
                        books.Insert(indexOfFirstBook, temp2);
                        books.Insert(indexOfSecondBook, temp1);
                    }
                }
                else if (type == "Insert")
                {
                    if (!books.Contains(bookName))
                    {
                        books.Add(bookName);
                    }
                }
                else if (type == "Check")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index >= 0 && index < books.Count) 
                    {
                        string item = books[index];
                        Console.WriteLine(item);
                    }
                }
            }
            Console.WriteLine(String.Join(", ", books));
        }
    }
}
