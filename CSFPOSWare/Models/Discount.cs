using System;

namespace CSFPOSWare.Models
{
    public partial class Discount : BaseModel
    {
        public Guid DiscountID { get; set; }
        public Guid RegionID { get; set; }
        public int DiscountIndex { get; set; }
        public string DiscountName { get; set; }
        public short DiscountType { get; set; }
        public int PercentOff { get; set; }
        public int DollarsOff { get; set; }
        public int MaxAmount { get; set; }
        public bool EnterAmount { get; set; }
        public bool SubFrTax { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public short Days { get; set; }
        public short Reason { get; set; }
        public short SecurityLevel { get; set; }
        public string Text { get; set; }
        public int DollarsOffSale { get; set; }
        public bool IsExclusive { get; set; }
        public bool DisplayInOwnSection { get; set; }
    }
}
