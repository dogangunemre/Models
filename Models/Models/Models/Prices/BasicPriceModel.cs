using System;
using System.Collections.Generic;
using System.Text;
using API_V16.Models.Currencies;
using API_V16.Models.Units;

namespace API_V16.Models.Prices
{
    public class BasicPriceModel
    {
        public string ID { get; set; }
        public int No { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public BasicUnitModel Unit { get; set; }
        public BasicCurrencyModel Currency { get; set; }
    }
}
