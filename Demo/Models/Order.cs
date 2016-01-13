using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Order
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public string ShippingAddress { get; set; }
        public string EmailAddress { get; set; }
    }
}