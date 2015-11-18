using System;

namespace CSFPOSWare.Models
{
    public partial class CSSaleTender : BaseModel
    {
        public Guid CSSaleTenderID { get; set; }
        public Guid SaleID { get; set; }
        public int TenderIndex { get; set; }
        public string MediaIndex { get; set; }
        public decimal Amount { get; set; }
    }
}