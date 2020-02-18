using System;
using System.Collections.Generic;
using TypesProduct.Entities;

namespace TypesProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>(); ;

            Console.Write("Enter the number of products: ");
            int numberOfProducts = int.Parse(Console.ReadLine());

            for(int i = 0; i < numberOfProducts; i++)
            {
                Product product;
                Console.WriteLine($"Product #{i + 1} data: ");

                Console.WriteLine("Common, used or imported? ( c / u / i )");
                char productType = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if(productType == 'u')
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, manufactureDate));

                }else if(productType == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine());

                    products.Add(new ImportedProduct(name, price, customFee));
                }
                else
                {
                    products.Add(new Product(name, price)); 
                }

            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS");

            foreach(Product product in products)
            {
                Console.WriteLine(product.PriceTag()); 
            }
        }
    }
}
