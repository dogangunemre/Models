
using System;
using System.Collections.Generic;
using System.Text;
using API_V16.Models.Prices;
using API_V16.Models.Regions;
using API_V16.Models.Units;

namespace API_V16.Models.Cargos
{
    public class BasicCargoServiceModel
    {
        public BasicRegionModel Region { get; set; }
        public BasicUnitModel Unit { get; set; }
        public decimal InitialMeasureValue { get; set; }
        public decimal EndMeasureValue { get; set; }
        public BasicPriceModel ServicePriceModel { get; set; }
        public decimal ServiceFee { get; set; }
    }
}
