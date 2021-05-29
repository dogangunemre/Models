using System;
using System.Collections.Generic;
using System.Text;

namespace API_V16.Models.Options
{
    public class BasicOptionModel
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public DataTypes DataType { get; set; }
        public string Description { get; set; }
    }
    public enum DataTypes
    {
        Text,
        Number,
        Float,
        File
    }
}
