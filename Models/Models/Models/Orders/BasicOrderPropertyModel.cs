﻿using System;
using System.Collections.Generic;
using System.Text;
using API_V16.Models.Properties;

namespace API_V16.Models.Orders
{
    public class BasicOrderPropertyModel
    {
        public BasicPropertyModel Property { get; set; }
        public string Value { get; set; }
    }
}
