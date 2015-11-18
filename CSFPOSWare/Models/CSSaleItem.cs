using System;

namespace CSFPOSWare.Models
{
    public class CSSaleItem : BaseModel
    {
        public Guid CSSaleItemID { get; set; }
        public Guid CSSaleID { get; set; }
        public string ItemName { get; set; }

        public int SeatNumber { get; set; }
        public decimal BasePrice { get; set; }
        public decimal AmountDue { get; set; }
        public int Quantity { get; set; }

        //public int vatableAmount { get; set; }
        //public int vatableTax { get; set; }
        //public int vatExemptAmount { get; set; }
        //public int vatExemptTax { get; set; }
        //public int zeroRatedAmount { get; set; }
        //public int zeroRatedtax { get; set; }
    }
}
