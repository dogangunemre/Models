
using System;
using System.Collections.Generic;
using System.Text;
using API_V16.Models.Brands;
using API_V16.Models.Files;
using API_V16.Models.Manufacturers;
using API_V16.Models.Options;
using API_V16.Models.Prices;
using API_V16.Models.ProductCategories;
using API_V16.Models.ProductGroups;
using API_V16.Models.Suppliers;
using API_V16.Models.Taxes;
using API_V16.Models.Units;

namespace API_V16.Models.Products
{
    public class BasicProductModel
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public BasicBrandModel Brand { get; set; }
        public BasicManufacturerModel Manufacturer { get; set; }
        public BasicSupplierModel Supplier { get; set; }
        public List<BasicProductCategoryModel> Categories { get; set; }

        public List<BasicProductGroupModel> Groups { get; set; }
        public List<BasicFileModel> Photos { get; set; }
        public BasicUnitModel Unit { get; set; }
        public List<BasicPriceModel> Prices { get; set; }
        public List<BasicProductStockModel> Stocks { get; set; }
        public BasicTaxModel Tax { get; set; }
        public List<BasicProductAttributeModel> Attributes { get; set; }
        public List<BasicProductLabelModel> Labels { get; set; }
        public List<BasicOptionModel> Options { get; set; }
        public List<BasicProductSettingModel> Settings { get; set; }
        public string Details { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public bool State { get; set; }
    }
}
