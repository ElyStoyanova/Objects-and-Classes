using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string inputCommand = Console.ReadLine();

            while (inputCommand != "end")
            {
                string[] tokans = inputCommand.Split();

                Box box = new Box
                {
                   SerialNumber= tokans[0],
                    Item =new Item(tokans[1], decimal.Parse(tokans[3])),
                   ItemQuontity= int.Parse(tokans[2])
                };
                boxes.Add(box);
                
                inputCommand = Console.ReadLine();
            }
            List<Box> orderBoxes = boxes.OrderByDescending(box => box.Price).ToList();

            foreach (Box order in orderBoxes)
            {
                Console.WriteLine(order.SerialNumber);
                Console.WriteLine($"-- {order.Item.Name} - ${order.Item.Price:f2}: {order.ItemQuontity}");
                Console.WriteLine($"-- ${order.Price:f2}");
            }
        }
    }
    class Item
    {
        public Item(string name,decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {    
       
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuontity { get; set; }
        public decimal Price 
        { 
            get
            {
                return this.ItemQuontity * this.Item.Price;
            }
        }
    }
}
