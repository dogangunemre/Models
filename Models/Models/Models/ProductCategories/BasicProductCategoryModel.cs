using System;
using System.Collections.Generic;
using System.Text;
using API_V16.Models.Files;

namespace API_V16.Models.ProductCategories
{
    public class BasicProductCategoryModel
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public BasicProductCategoryModel ParentCategory { get; set; }
        public BasicFileModel Photo { get; set; }
        public List<BasicProductCategoryPropertyModel> Properties { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public int Order { get; set; }
        public bool State { get; set; }
    }
}
