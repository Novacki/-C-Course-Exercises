using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSummary.Entities.Enuns
{
    class OrdemItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrdemItem()
        {

        }

        public OrdemItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price; 
        }
    }
}
