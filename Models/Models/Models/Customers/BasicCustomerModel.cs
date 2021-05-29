
using System;
using System.Collections.Generic;
using System.Text;
using API_V16.Models.Adresses;
using API_V16.Models.CustomerGroups;
using API_V16.Models.Regions;

namespace API_V16.Models.Customers
{
    public class BasicCustomerModel
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public BasicRegionModel Region{ get; set; }
        public string Description { get; set; }
        public string CitizenNumber { get; set; }
        public List<BasicAddressModel> Addresses { get; set; }
        public List<BasicCustomerGroupModel>  CustomerGroups { get; set; }
        public string State { get; set; }
    }
}
