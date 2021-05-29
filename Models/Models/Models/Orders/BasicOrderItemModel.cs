using System;
using System.Collections.Generic;
using System.Text;
using API_V16.Models.Products;

namespace API_V16.Models.Orders
{
    public class BasicOrderItemModel
    {
        public string ID { get; set; }
        public BasicProductModel Product { get; set; }
        public int Amount { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
