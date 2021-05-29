using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_V16.Models.Currencies
{
   public class BasicCurrencyModel
    {
        public string ID { get; set; }
        public int No{ get; set; }
        public string FundCode { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
    }
}
