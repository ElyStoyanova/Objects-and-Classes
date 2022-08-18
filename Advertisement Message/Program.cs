using System;
using System.Collections.Generic;

namespace Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phrase = new List<string>()
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can't live without this product."
            };
            List<string> events = new List<string>()
            {
            "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"
            };
            List<string> autor = new List<string>()
            {
            "Diana",
            "Petya",
            "Stella",
            "Elena",
            "Katya",
            "Iva",
            "Annie",
            "Eva"
            };
            List<string> city = new List<string>()
            {
            "Burgas",
            "Sofia",
            "Plovdiv",
            "Varna",
            "Ruse"
            };

            int messages = int.Parse(Console.ReadLine());
            Random random = new Random();

            for (int i = 0; i < messages; i++)
            {
                Console.WriteLine($"{phrase[random.Next(phrase.Count)]} {events[random.Next(events.Count)]} {autor[random.Next(autor.Count)]} - {city[random.Next(city.Count)]}");
            }
        }
    }
}
