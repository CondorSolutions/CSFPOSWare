using System;

namespace CSFPOSWare.Models
{
    public partial class CSConfiguration : BaseModel
    {
        public Guid CSConfigurationID { get; set; }
        public string Section { get; set; }
        public string Parameter { get; set; }
        public string ParameterType { get; set; }
        public int ParameterIndex { get; set; }
        public string Value { get; set; }

        public partial class Sections
        {
            public static string General = "General";
            public static string DiscountIndexMap = "DiscountIndexMap";
        }

        public partial class Parameters
        {
            public static string PWDIndex = "PWDIndex";
            public static string SeniorIndex = "SeniorIndex";
            public static string MallSetup = "MallSetup";
        }

        public partial class Values
        {
            public static string SM = "SM";
            public static string Megaworld = "Megaworld";
        }
    }
}
