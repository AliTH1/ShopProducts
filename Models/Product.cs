using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task190423.Models
{
    internal class Product
    {
        public Product(string title, string description, bool inStock, double price)
        {
            Count++;
            Id = Count;
            Title = title;
            Description = description;
            InStock = inStock;
            Price = price;
        }

        public static int Count { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool InStock { get; set; }
        public double Price { get; set; }

        private string _code;
        public string Code 
        {
            get
            {
                string[] arr = Title.Split(' ');
                string str = "";
                foreach (string str2 in arr)
                {
                    str += str2[0];
                }

                return $"{str}{Id}";
            }
        }


        public override string ToString()
        {
            return $"Title: {Title} \nDescription: {Description} \nPrice: {Price}\n\n";
        }
    }
}
