using LINQ_Assignment1.Models;
using System.Drawing;
using System.Xml.Linq;
using static LINQ_Assignment1.DataSources.Source;

namespace LINQ_Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            // //1.Get all products from the "Seafood" category.Print
            // //each product's name and price.
            //// meathod syntax
            // var SeafoodProducts = ProductList.Where(p => p.Category == "Seafood");
            // foreach (var item in SeafoodProducts)
            // {
            //     Console.WriteLine(item);
            // }
            // Console.WriteLine("================================");
            // // query syntax 
            // var QuerySeafood = from p in ProductList
            //                    where p.Category == "Seafood"
            //                    select p;
            // foreach (var item in QuerySeafood)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region Task2
            ////2.Get a list of only the product names from ProductList.
            //// Print each name.

            //var ProductsName = ProductList.Select(p => p.ProductName);
            //foreach (var item in ProductsName)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("=====================================");
            //var QueryProductsName = from p in ProductList
            //                        select p.ProductName;
            //foreach (var item in QueryProductsName)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region task3
            //3.Get all products where UnitPrice is between 10 and 30

            //var ProductsWhereUnitPriceBetween10And30 = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
            //foreach (var item in ProductsWhereUnitPriceBetween10And30)
            //{
            //    Console.WriteLine(item);   
            //}
            //Console.WriteLine("====================");
            //var QueryProductsWhereUnitPriceBetween10And30 = from p in ProductList
            //                                                where p.UnitPrice >= 10 && p.UnitPrice <= 30
            //                                                select p;
            //foreach (var item in QueryProductsWhereUnitPriceBetween10And30)
            //{
            //    Console.WriteLine(item);   
            //}


            #endregion

            #region task4
            //4.Get all products that are in stock(UnitsInStock >0) 
            //    and belong to the "Condiments" category.
            //var CondimentsCategory = ProductList.Where(p => p.Category.Contains("Condiments"));
            //foreach (var item in CondimentsCategory)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("==================================");

            //var productsinStockANDCondimentsCategory = ProductList.Where(p => p.UnitsInStock > 0 && p.Category.Contains("Condiments"));
            //foreach (var item in productsinStockANDCondimentsCategory)
            //{
            //    Console.WriteLine(item);

            //}
            //Console.WriteLine("==================================");

            //var QueryproductsinStockANDCondimentsCategory = from p in ProductList
            //                                                where p.UnitsInStock > 0 && p.Category.Contains("Condiments")
            //                                                select p;
            //foreach (var item in QueryproductsinStockANDCondimentsCategory)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region task5
            //5.Create a new anonymous type with three
            //   properties: ● Name → the product name
            //   ● Price → the unit price
            //   ● StockStatus → a string: "Available" if
            //   UnitsInStock > 0, otherwise "Out of Stock"
            //   ● Print the result.


            var ProductInfo = ProductList.Select(p => new { Name = p.ProductName, Price = p.UnitPrice, StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock" });
            foreach (var item in ProductInfo)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
