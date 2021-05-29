
using System;
using System.Collections.Generic;
using System.Text;
using API_V16.Models.Adresses;
using API_V16.Models.Properties;

namespace API_V16.Models.Stores
{
    public class BasicStoreModel
    {
        public string ID { get; set; }
        public int CompanyID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public BasicAddressModel Address { get; set; }
        public List<BasicPropertyModel> Properties { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
    }
}
