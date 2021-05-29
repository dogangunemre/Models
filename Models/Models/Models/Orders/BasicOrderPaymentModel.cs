
using System;
using System.Collections.Generic;
using System.Text;
using API_V16.Models.Currencies;
using API_V16.Models.Customers;
using API_V16.Models.PaymentMethods;

namespace API_V16.Models.Orders
{
    public class BasicOrderPaymentModel
    {
        public string ID { get; set; }
        public BasicPaymentMethodModel PaymentMethod { get; set; }
        public BasicCustomerModel Customer { get; set; }
        public BasicCurrencyModel Currency { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public bool State { get; set; }
    }
}
