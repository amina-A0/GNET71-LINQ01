namespace LINQAssignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1

            var seafoodProducts = ProductList.Where(p => p.Category == "Seafood");

            foreach (var p in seafoodProducts)
            {
                Console.WriteLine($"Name: {p.ProductName}, Price: {p.UnitPrice}");
            }

            #endregion

        }
    }
}
