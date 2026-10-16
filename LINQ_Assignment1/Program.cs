using LINQ_Assignment1.Models;
using static LINQ_Assignment1.DataSources.Source;

namespace LINQ_Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //1.Get all products from the "Seafood" category.Print
            //each product's name and price.
           // meathod syntax
            var SeafoodProducts = ProductList.Where(p => p.Category == "Seafood");
            foreach (var item in SeafoodProducts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("================================");
            // query syntax 
            var QuerySeafood = from p in ProductList
                               where p.Category == "Seafood"
                               select p;
            foreach (var item in QuerySeafood)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
