using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace API_V16.Models.PaymentStatuses
{
    public class BasicPaymentStatusModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public enum PaymentStatuses
    {
        [Description("Ödenmedi")]
        NotPaid = 0,
        [Description("Ödendi")]
        Paid=1,
        [Description("Parçalı Ödendi")]
        PartiallyPaid= 2,

    }
}
