
using System;
using System.Collections.Generic;
using System.Text;
using API_V16.Models.Brands;
using API_V16.Models.Files;

namespace API_V16.Models.Cargos
{
    public class BasicCargoModel
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public BasicFileModel Photo { get; set; }
        public List<BasicCargoServiceModel> Services { get; set; }
        public List<BasicBrandPropertyModel> Properties { get; set; }
    }
}
