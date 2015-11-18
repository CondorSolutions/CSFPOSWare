using System;

namespace CSFPOSWare.Models
{
    public partial class Configuration : BaseModel
    {
        public Guid ConfigurationID { get; set; }
        public int StoreID { get; set; }
        public int TerminalNumber { get; set; }
        public string Section { get; set; }
        public string Parameter { get; set; }
        public int ParameterIndex { get; set; }
        public string Value { get; set; }
    }
}
