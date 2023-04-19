using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task190423.Models
{
    internal class Shop
    {
        public int Id { get; set; }
        public string Title { get; set; }
        Product[] products = new Product[0];


        public Product[] AddProduct(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
            return products;
        }

        
        public Product GetProduct(int id)
        {
            foreach (Product product in products)
            {
                if (product.Id == id) 
                {
                    return product;
                }
            }
            return null;
        }

        public Product GetProduct(string title)
        {
            foreach (Product product in products)
            {
                if (product.Title == title)
                {
                    return product;
                }
            }
            return null;
        }

        public Product GetProduct(double minPrice, double maxPrice)
        {
            foreach(Product product in products)
            {
                if (product.Price > minPrice && product.Price < maxPrice)
                {
                    return product;
                }
            }
            return null;
        }

        public Product[] GetInStockProducts()
        {
            Product[] inStock = new Product[0];
            int index = 0;
            foreach (Product product in products)
            {
                if (product.InStock)
                {
                    Array.Resize(ref inStock, inStock.Length + 1);
                    inStock[index] = product;
                }

                index++;
            }

            return inStock;
        }
    }
}
