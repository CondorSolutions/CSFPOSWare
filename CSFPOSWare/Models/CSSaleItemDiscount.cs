using System;

namespace CSFPOSWare.Models
{
    public class CSSaleItemDiscount : BaseModel
    {
        public Guid CSSaleItemDiscountID { get; set; }
        public Guid CSSaleItemID { get; set; }
        public int ItemIndex { get; set; }
        public int DiscountIndex { get; set; }
        public string DiscountName { get; set; }
        public decimal Amount { get; set; }
    }
}