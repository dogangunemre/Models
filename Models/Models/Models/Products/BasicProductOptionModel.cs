using System;
using System.Collections.Generic;
using System.Text;
using API_V16.Models.Attributes;
using API_V16.Models.Options;

namespace API_V16.Models.Products
{
    public class BasicProductOptionModel
    {
        public BasicOptionModel Option { get; set; }
        public string Value { get; set; }
    }
}
