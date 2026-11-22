using System;
using System.Collections.Generic;
using System.Text;

namespace LINQAssignment01
{
    public class Product
    {
        public string ProductName { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}