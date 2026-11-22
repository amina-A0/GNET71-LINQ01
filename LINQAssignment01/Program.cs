using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQAssignment01
{
    internal class Program
    {
        static List<Product> ProductList = new List<Product>();

        static List<Order> OrderList = new List<Order>();

        static void Main(string[] args)
        {

            #region Q1

            var seafoodProducts = ProductList.Where(p => p.Category == "Seafood");

            foreach (var p in seafoodProducts)
            {
                Console.WriteLine($"Name: {p.ProductName}, Price: {p.UnitPrice}");
            }

            #endregion

            #region Q2

            var productNames = ProductList.Select(p => p.ProductName);

            foreach (var name in productNames)
            {
                Console.WriteLine(name);
            }

            #endregion

            #region Q3

            var sortedProducts = ProductList.OrderBy(p => p.UnitPrice);

            foreach (var p in sortedProducts)
            {
                Console.WriteLine($"Name: {p.ProductName}, Price: {p.UnitPrice}");
            }

            #endregion

            #region Q4

            var productsByPrice = ProductList.Where(
                p => p.UnitPrice >= 10 && p.UnitPrice <= 30
            );

            foreach (var p in productsByPrice)
            {
                Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            }

            #endregion

            #region Q5

            var availableCondiments = ProductList.Where(
                p => p.UnitsInStock > 0 && p.Category == "Condiments"
            );

            foreach (var p in availableCondiments)
            {
                Console.WriteLine(
                    $"{p.ProductName} - Stock: {p.UnitsInStock}"
                );
            }

            #endregion

            #region Q6

            var productStatus = ProductList.Select(p => new
            {
                Name = p.ProductName,
                Price = p.UnitPrice,
                StockStatus = p.UnitsInStock > 0
                    ? "Available"
                    : "Out of Stock"
            });

            foreach (var p in productStatus)
            {
                Console.WriteLine(
                    $"Name: {p.Name}, Price: {p.Price}, Status: {p.StockStatus}"
                );
            }

            #endregion

            #region Q7

            var productsWithIndex = ProductList.Select(
                (p, index) => $"{index + 1}. {p.ProductName}"
            );

            foreach (var item in productsWithIndex)
            {
                Console.WriteLine(item);
            }

            #endregion
        }
    }
}
