using System;
using System.Collections.Generic;
using System.Text;
using API_V16.Models.Regions;

namespace API_V16.Models.Taxes
{
    public class BasicTaxModel
    {
        public string ID { get; set; }
        public int CompanyID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public BasicRegionModel Region { get; set; }
    }
}
