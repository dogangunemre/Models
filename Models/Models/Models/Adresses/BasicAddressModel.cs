
using System;
using System.Collections.Generic;
using System.Text;

namespace API_V16.Models.Adresses
{
    public class BasicAddressModel
    {
        public string ID { get; set; }
        public int No { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string FullAddress { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public bool State { get; set; }
    }
}
