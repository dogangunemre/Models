using System;
using System.Collections.Generic;
using System.Text;

namespace API_V16.Models.Files
{
    public class BasicFileModel
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string MIMEType { get; set; }
        public string Path { get; set; }
        public PathTypes PathType { get; set; }
        public string Description { get; set; }
    }
    public enum PathTypes
    {
        Absolute,
        Relative,
        Remote
    }
}
