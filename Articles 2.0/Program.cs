using System;
using System.Collections.Generic;

namespace Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                Article article = new Article()
                {
                    Title = input[0],
                    Content = input[1],
                    Autor = input[2]
                };
                articles.Add(article);
            }
            Console.WriteLine(string.Join("\n",articles));
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
