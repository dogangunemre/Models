using System;
using System.Collections.Generic;
using System.Text;
using API_V16.Models.Files;

namespace API_V16.Models.CustomerGroups
{
    public class BasicCustomerGroupModel
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public BasicCustomerGroupModel ParentGroup { get; set; }
        public BasicFileModel Photo { get; set; }
        public List<BasicCustomerGroupPropertyModel> Properties { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public bool State { get; set; }
    }
}
