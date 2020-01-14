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
        public List<OrdemItem> Items { get; set; }

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrdemItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrdemItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach(OrdemItem item in Items)
            {
                sum += item.Price;
            }

            return sum;
        }
    }
}
