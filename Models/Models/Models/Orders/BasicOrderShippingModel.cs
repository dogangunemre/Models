
using System;
using System.Collections.Generic;
using System.Text;
using API_V16.Models.Adresses;
using API_V16.Models.Cargos;

namespace API_V16.Models.Orders
{
    public class BasicOrderShippingModel
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public BasicCargoModel[] Cargo { get; set; }
        public List<BasicOrderItemModel> Items { get; set; }
        public long DeliveryDate { get; set; }
        public BasicAddressModel DeliveryAddress { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public bool State { get; set; }
    }
}
