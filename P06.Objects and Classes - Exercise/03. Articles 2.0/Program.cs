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

       
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          List<Article> article = new List<Article>();

            int n = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < n; i++)
            {
                string[] articleArg = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string title = articleArg[0];
                string content = articleArg[1];
                string author = articleArg[2];
                Article newArticle = new Article(title, content, author);
                article.Add(newArticle);
            }
            string command = Console.ReadLine();
            if (command== "title")
            {
                article = article.OrderBy(a => a.Title).ToList();
                foreach (Article item in article)
                {
                    Console.WriteLine(item);
                }              
            }
            else if (command == "content")
            {
                article = article.OrderBy(a => a.Content).ToList();
                foreach (Article item in article)
                {
                    Console.WriteLine(item);
                }
            }
            else if (command == "author")
            {
                article = article.OrderBy(a => a.Author).ToList();
                foreach (Article item in article)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
