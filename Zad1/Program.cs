using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> availableProducts = new List<Product>
        {
            new Product { Name = "Apple", Price = 2.5 },
            new Product { Name = "Banana", Price = 1.2 },
            new Product { Name = "Laptop", Price = 800 },
            new Product { Name = "Headphones", Price = 50 },
            new Product { Name = "Orange", Price = 3 }
        };
            List<OrderItem> customerOrder = new List<OrderItem>
        {
            new OrderItem { ProductName = "Apple", Quantity = 3 },
            new OrderItem { ProductName = "Banana", Quantity = 5 },
            new OrderItem { ProductName = "Laptop", Quantity = 1 },
            new OrderItem { ProductName = "Headphones", Quantity = 2 }
        };
            var validOrder = customerOrder.Where(x => availableProducts.Any(p => p.Name == x.ProductName)).ToList();
            var totalCost = validOrder.Sum(x => x.Quantity * availableProducts.First(p => p.Name == x.ProductName).Price);
            Console.WriteLine($"Обща цена на поръчката: {totalCost:F2} лв");
            var sortedOrder = validOrder.OrderByDescending(x => x.Quantity).ToList();
            Console.WriteLine("\nПодредена поръчка по количество:");
            sortedOrder.ForEach(x => Console.WriteLine($"{x.ProductName}: {x.Quantity} бр."));
            var mostExpensiveProduct = validOrder.OrderByDescending(x => availableProducts.First(p => p.Name == x.ProductName).Price).First();
            Console.WriteLine($"\nНай-скъп продукт: {mostExpensiveProduct.ProductName}");
        }
    }
}
