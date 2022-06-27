using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._School_Library_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine().Split("&", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command;
            while ((command = Console.ReadLine()) != "Done")
            {
                List<string> cmdArgs = command.Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
                string cmdType = cmdArgs[0];
                string bookName = cmdArgs[1];

                if (cmdType== "Add Book ")
                {
                    if (!books.Contains(bookName))
                    {
                        books.Insert(0, bookName);
                    }
                }
                else if (cmdType == "Take Book ")
                {
                    if (books.Contains(bookName))
                    {
                        int index = books.IndexOf(bookName);
                        books.RemoveAt(index);
                    }
                }
                else if (cmdType == "Swap Books  ")
                {                   
                    string newBook = cmdArgs[2];
                    if (books.Contains(bookName) && books.Contains(newBook))
                    {
                        int indexOfFirstBook = books.IndexOf(bookName);
                        int indexOfSecondBook = books.IndexOf(newBook);
                        books.Insert(indexOfSecondBook, bookName);
                        books.Insert(indexOfFirstBook, newBook);
                    }
                }
                else if (cmdType == "Insert Book ")
                {
                    if (!books.Contains(bookName))
                    {
                        books.Add(bookName);
                    }
                }
                else if (cmdType == "Check Book  ")
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
