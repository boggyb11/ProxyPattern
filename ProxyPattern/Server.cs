﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    class Server : IServer
    {
        private string Order;

        public void TakeOrder(string order)
        {
            Console.WriteLine("Server takes order for " + order + ".");
            Order = order;
        }
        public string DeliverOrder()
        {
            return Order;
        }

        public void ProcessPayment(string payment)
        {
            Console.WriteLine("Payment for order (" + payment + ") processed.");
        }
    }
}
