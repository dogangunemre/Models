
using System;
using System.Collections.Generic;
using System.Text;
using API_V16.Models.Adresses;
using API_V16.Models.Stores;


namespace API_V16.Models.Warehouses
{
    public class BasicWarehouseModel
    {
        public string ID { get; set; }
        public int CompanyID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public BasicStoreModel Store { get; set; }
        public BasicAddressModel Address { get; set; }
        public string Description { get; set; }
    }
}
