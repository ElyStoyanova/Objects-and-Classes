using System;
using System.Collections.Generic;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            Article article = new Article()
            {
                Title = input[0],
                Content = input[1],
                Autor = input[2]
            };

            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                string[] inputCommand = Console.ReadLine().Split(": ");

                switch (inputCommand[0])
                {
                    case "Edit":
                        article.Content = inputCommand[1];
                        break;
                    case "ChangeAuthor":
                        article.Autor = inputCommand[1];
                        break;
                    case "Rename":
                        article.Title = inputCommand[1];
                        break;
                }
            }
            Console.WriteLine(article);
        }
    }
    class Article
    {
        public override string ToString()
        {
            return $"{Title} - {Content}: {Autor}";
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Autor { get; set; }
        
    }
}
