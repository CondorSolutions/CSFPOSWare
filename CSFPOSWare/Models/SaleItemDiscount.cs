using System;

namespace CSFPOSWare.Models
{
    public partial class SaleItemDiscount : BaseModel
    {
        public Guid SaleItemDiscountID { get; set; }
        public Guid SaleItemID { get; set; }
        public short ItemIndex { get; set; }
        public int DiscountIndex { get; set; }
        public int Amount { get; set; }
    }
}
