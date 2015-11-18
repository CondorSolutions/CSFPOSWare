using System;

namespace CSFPOSWare.Models
{
    public partial class SaleTender : BaseModel
    {
        public Guid SaleTenderID { get; set; }
        public Guid SaleID { get; set; }
        public int TenderIndex { get; set; }
        public int MediaIndex { get; set; }
        public int Amount { get; set; }
        public int ForeignIndex { get; set; }
        public int ForeignAmount { get; set; }
        public int Customer { get; set; }
        public int EmployeeTip { get; set; }
        public int HouseTip { get; set; }
        public bool UseTipCalc { get; set; }
        public Nullable<System.Guid> SignatureID { get; set; }
    }
}
