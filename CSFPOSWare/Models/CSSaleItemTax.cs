using System;

namespace CSFPOSWare.Models
{
    public class CSSaleItemTax : BaseModel
    {

        public Guid CSSaleItemTaxID { get; set; }
        public Guid CSSaleItemID { get; set; }
        public int Type { get; set; }
        public decimal Amount { get; set; }
        public decimal Tax { get; set; }

        public class Types
        {
            public static int VAT = 0;
            public static int VATExempt = 1;
            public static int ZERORated = 2;
            public static int Local = 3;
            public static int Other = 4;
        }
    }
}