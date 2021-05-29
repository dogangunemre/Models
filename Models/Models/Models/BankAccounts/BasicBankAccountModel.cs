using System;
using System.Collections.Generic;
using System.Text;
using API_V16.Models.Banks;

namespace API_V16.Models.BankAccounts
{
    public class BasicBankAccountModel
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        public string Number { get; set; }
        public string IBAN { get; set; }
        public string SwiftCode { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public BasicBankModel Bank { get; set; }
    }
}
