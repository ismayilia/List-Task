using LessonTask.Models;
using LessonTask.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask.Services
{
    internal class ProducService : IProductService
    {
        public List<Product> GetAll()
        {

            List<Product> products = new()
            {
                new Product {Id = 1, Name = "Television", Price = 10, Count=5 },
                new Product {Id = 1, Name="Computer", Price = 10, Count=3 },
                new Product {Id = 1, Name="Phon", Price = 10, Count=2 }
            };
            return products;
        }

        
        public void SearchByName(string text)
        {
            List<Product> products = GetAll();
            foreach (var item in products)
            {
                if (item.Name.Trim().ToLower().Contains(text.Trim().ToLower()))
                {
                    Console.WriteLine($"{item.Id} {item.Name} {item.Price} {item.Count}");
                }
            }

        }






    }
}
