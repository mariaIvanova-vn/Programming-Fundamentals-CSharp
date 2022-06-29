using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{

    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
       
        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void	Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string[] articleArg = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string title = articleArg[0];
            string content = articleArg[1];
            string author = articleArg[2];
            

            int n = int.Parse(Console.ReadLine());
            Article article = new Article(title, content, author);
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string commandType = commands[0];
                string commandValue = commands[1];
                if (commandType == "Edit")
                {
                    article.Edit(commandValue);
                }

                else if (commandType == "ChangeAuthor")
                {
                    article.ChangeAuthor(commandValue);
                }

                else if (commandType == "Rename")
                {
                    article.Rename(commandValue);
                }
            }
            Console.WriteLine(article.ToString());
        }
    }
}
