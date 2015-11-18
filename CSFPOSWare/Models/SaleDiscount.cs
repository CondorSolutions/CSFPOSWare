using System;

namespace CSFPOSWare.Models
{
    public partial class SaleDiscount
    {
        public Guid SaleDiscountID { get; set; }
        public Nullable<Guid> SaleID { get; set; }
        public int DiscountIndex { get; set; }
        public int Dollar { get; set; }
        public int Amount { get; set; }
        public int ReasonIndex { get; set; }
        public int MaxAmount { get; set; }
    }
}