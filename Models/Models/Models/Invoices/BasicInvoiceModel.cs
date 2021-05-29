

using System;
using System.Collections.Generic;
using System.Text;
using API_V16.Models.Adresses;
using API_V16.Models.Currencies;
using API_V16.Models.Customers;
using API_V16.Models.Files;
using API_V16.Models.Orders;
using API_V16.Models.Stores;

namespace API_V16.Models.Invoices
{
    public class BasicInvoiceModel
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public BasicStoreModel Store { get; set; }
        public long Date { get; set; }
        public BasicCustomerModel Customer { get; set; }
        public List<BasicOrderItemModel> Items { get; set; }
        public BasicAddressModel DeliveryAddress { get; set; }
        public BasicAddressModel InvoiceAddress { get; set; }
        public BasicOrderModel Order { get; set; }
        public PaymentTypes PaymentType { get; set; }
        public BasicCurrencyModel Currency { get; set; }
        public decimal SubTotal { get; set; }
        public decimal DiscountTotal { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal Paid { get; set; }
        public decimal Due { get; set; }
        public BasicFileModel Photo { get; set; }

        public enum PaymentTypes
        {
            Cash = 0,
            Credit = 19,
            CashOnDelivery = 0,
            CreditOnDelivery = 19,
            Transfer
        }
    }
}
