using System;
using System.Collections.Generic;
using System.Text;
using API_V16.Models.Labels;

namespace API_V16.Models.Products
{
    public class BasicProductLabelModel
    {
        public BasicLabelModel Label { get; set; }
        public string Value { get; set; }
    }
}
