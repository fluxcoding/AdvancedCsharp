﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Classes
{
    public class Order
    {
        private List<OrderLine> _orderLines = new List<OrderLine>();
        public void AddOrderLine(string product, int quantity, double price)
        {
            OrderLine line = new OrderLine();
            line.ProductName = product;
            line.Quantity = quantity;
            line.Price = price;
            _orderLines.Add(line);
        }

        public double OrderTotal()
        {
            double total = 0;
            foreach (var orderLine in _orderLines)
            {
                total += orderLine.OrderLineTotal();
               
            }

            return total;
        }



        private class OrderLine
        {
            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public double Price { get; set; }
            public double OrderLineTotal()
            {
                return Price * Quantity;
            }
        }
    }
}
