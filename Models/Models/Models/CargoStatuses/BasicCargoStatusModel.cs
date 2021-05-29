using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace API_V16.Models.CargoStatuses
{
    public class BasicCargoStatusModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public enum CargoStatuses{
        [Description("Kargoya Teslim Edilmedi")]
        CargoNotDelivered=0,
        [Description("Kargoya Teslim Edildi")]
        CargoDelivered = 1,
    }
}
