using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var catges = new List<Category>()
            {
                new Category{ID = 1, Name = "Vay"},
                new Category{ID = 2, Name = "Ao coc tay"},
                new Category{ID = 3, Name = "Ao dai tay"},
                new Category{ID = 4, Name = "Quan"}
            };

            var products = new List<Product>()
            {
                new Product(1, "Vay ngan",    400, new string[] {"Xam", "Xanh"},         1),
                new Product(2, "Quan jean", 400, new string[] {"Vang", "Xanh"},        4),
                new Product(3, "Den trum",   500, new string[] {"Trang"},               1),
                new Product(4, "Ao polo",    200, new string[] {"Trang", "Xanh"},       2),
                new Product(5, "Ao thun",     300, new string[] {"Do", "Den", "Vang"},   2),
                new Product(6, "So mi", 500, new string[] {"Trang"},               3),
                new Product(7, "Vest",      600, new string[] {"Trang"},               3),
            };

            var results = products.Join(catges, s => s.Category, x => x.ID, (products, catges) => new { 
                ID = products.ID,
                Name = products.Name,
                Price = products.Price,
                Category = catges.Name
            });
            foreach (var item in results)
            {
                Console.WriteLine(item.ToString());
            }
            ////tim san pham co 
            //var results = products.Join(brands, s => s.Brand, x => x.ID, (products, brands) => new
            //{                
            //    Brand = brands.Name,
            //    ID = products.ID,
            //    Name = products.Name
            //}) ;//.GroupBy(s => s.Price).ToList();
            //foreach (var item in results)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //results.ToString()
            //foreach (var item in results)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var item2 in item)
            //    {
            //        Console.WriteLine(item2.ToString());
            //    }
            //}
            Console.ReadLine();
        }
    }
}
