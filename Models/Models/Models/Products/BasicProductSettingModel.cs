using System;
using System.Collections.Generic;
using System.Text;
using API_V16.Models.Settings;

namespace API_V16.Models.Products
{
    public class BasicProductSettingModel
    {
        public BasicSettingModel Setting { get; set; }
        public string Value { get; set; }
    }
}
