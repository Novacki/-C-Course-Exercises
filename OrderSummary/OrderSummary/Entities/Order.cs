using OrderSummary.Entities.Enuns;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSummary.Entities
{
    class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach(OrderItem item in Items)
            {
                sum += item.Price;
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            
            builder.AppendLine("Order Summary: ");
            builder.AppendLine("Order Moment: " + Moment);
            builder.AppendLine("Order Status: " + Status);
            builder.AppendLine("Client: " + Client);

            builder.AppendLine("Order Itens: ");

            double sum = 0;

            Console.WriteLine();

            foreach(OrderItem orderItem in Items)
            {
                sum += orderItem.SubTotal();

                builder.AppendLine(orderItem.ToString());
                
            }

            builder.AppendLine("Total Price: " + $"${sum}");
            Console.WriteLine();

            return builder.ToString();
        }

        
    }
}
