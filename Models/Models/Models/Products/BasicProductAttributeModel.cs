using System;
using System.Collections.Generic;
using System.Text;
using API_V16.Models.Attributes;

namespace API_V16.Models.Products
{
    public class BasicProductAttributeModel
    {
        public BasicAttributeModel Attribute { get; set; }
        public string Value { get; set; }
    }
}
