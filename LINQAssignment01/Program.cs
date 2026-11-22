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

        }
    }
}
