
using System;
using System.Collections.Generic;
using System.Text;
using API_V16.Models.Cargos;
using API_V16.Models.Files;

namespace API_V16.Models.Brands
{
    public class BasicBrandModel
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public BasicFileModel Photo { get; set; }
        public List<BasicCargoPropertyModel> Properties { get; set; }

    }
}
