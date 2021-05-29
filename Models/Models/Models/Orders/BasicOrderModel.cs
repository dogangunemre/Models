
using System;
using System.Collections.Generic;
using System.Text;
using API_V16.Models.Adresses;
using API_V16.Models.Currencies;
using API_V16.Models.Customers;
using API_V16.Models.Invoices;
using API_V16.Models.Stores;


namespace API_V16.Models.Orders
{
    public class BasicOrderModel
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public BasicStoreModel Store { get; set; }
        public long Date { get; set; }
        public BasicCustomerModel Customer { get; set; }
        public List<BasicOrderItemModel> Items { get; set; }
        public List<BasicOrderPaymentModel> Payments { get; set; }
        public List<BasicOrderShippingModel> Shippings { get; set; }
        public BasicAddressModel DeliveryAddress { get; set; }
        public BasicAddressModel InvoiceAddress { get; set; }
        public BasicOrderPropertyModel Properties { get; set; }
        public BasicInvoiceModel Invoice { get; set; }
        public PaymentTypes PaymentType { get; set; }
        public BasicCurrencyModel Currency { get; set; }
        public string Note { get; set; }
        public decimal SubTotal { get; set; }
        public decimal DiscountTotal { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal Paid { get; set; }
        public decimal Due { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

    }
    public enum PaymentTypes
    {
        Cash,
        Credit,
        CashOnDelivery,
        CreditOnDelivery,
        Transfer
    }
}
