
using System;
using System.Collections.Generic;
using System.Text;
using API_V16.Models.Warehouses;

namespace API_V16.Models.Products
{
    public class BasicProductStockModel
    {
        public BasicWarehouseModel Warehouse { get; set; }
        public decimal Amount { get; set; }

    }
}
