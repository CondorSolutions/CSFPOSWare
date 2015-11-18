using System;

namespace CSFPOSWare.Models
{
    public partial class CSSale : BaseModel
    {
        //Sales info
        public Guid CSSaleID { get; set; }
        public Nullable<int> ORNo { get; set; }
        public int CheckNo { get; set; }
        public bool IsRefunded { get; set; }
        public bool IsCancelled { get; set; }
        public decimal GrossSales { get; set; } //SM: TSL_DAY_A(9) - Dept sum
        public decimal NetSales { get; set; } //SM: TSL_NET_A(29) - Daily sales
        public Nullable<DateTime> EndDate { get; set; }
        public decimal Tip { get; set; }
        public int CustomerCount { get; set; }
        public decimal ExcessGC { get; set; }

        //Other charges
        public decimal serviceCharge { get; set; } //SM: TSL_SV_CHG(45) - Service charge
        public decimal otherCharges { get; set; } //SM: TSL_OT_CHG(46) - Otehr charges

        //public virtual ICollection<CSSaleItem> CSSaleItems { get; set; }
    }
}