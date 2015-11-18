using System;

namespace CSFPOSWare.Models
{
    public partial class SaleTax : BaseModel
    {
        public Guid SaleTaxID { get; set; }
        public Guid SaleID { get; set; }
        public int TaxIndex { get; set; }
        public int WorkTax { get; set; }
        public int OrigionalTax { get; set; }
    }
}
