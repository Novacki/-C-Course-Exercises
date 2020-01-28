using OrderSummary.Entities;
using System;
using OrderSummary.Entities.Enuns;


namespace OrderSummary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Customer Data");
            Console.Write("Name: "); 
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client customer = new Client(name, email, birthDate);

            Console.WriteLine("Enter Order Data: ");
            Console.WriteLine("Status: ");

            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, customer);

            Console.WriteLine("How many items to this order? ");
            int quantity = int.Parse(Console.ReadLine());

            for(int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Enter #{i + 1} Data: ");

                Console.WriteLine("Product Name: ");
                string productName = Console.ReadLine();
                
                Console.WriteLine("Product Price: ");
                double price = double.Parse(Console.ReadLine());

                Console.WriteLine("Quantity: ");
                int quantityProduct = int.Parse(Console.ReadLine());

                Product product = new Product(productName, price);
                OrderItem orderItem = new OrderItem(quantityProduct, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine(order);
         }
    }
}
