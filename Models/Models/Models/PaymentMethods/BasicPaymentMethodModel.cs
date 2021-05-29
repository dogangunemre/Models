﻿using System;
using System.Collections.Generic;
using System.Text;

namespace API_V16.Models.PaymentMethods
{
    public class BasicPaymentMethodModel
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public bool State { get; set; }
    }
}
