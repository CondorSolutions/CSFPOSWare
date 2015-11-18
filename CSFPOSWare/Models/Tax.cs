using System;

namespace CSFPOSWare.Models
{
    public partial class Tax : BaseModel
    {
        public Guid TaxID { get; set; }
        public int StoreID { get; set; }
        public short TaxIndex { get; set; }
        public string TaxName { get; set; }
        public short TaxType { get; set; }
        public bool IsVAT { get; set; }
        public bool AddOddPennies { get; set; }
        public int NoTaxUnder { get; set; }
        public short CalculationType { get; set; }
        public int TaxPercent { get; set; }
        public short RoundingType { get; set; }
        public short LastUpToIndex { get; set; }
        public int ScheduledDays { get; set; }
        public bool DoNotIncludeInDisplayedTotal { get; set; }
        public bool IncludeInAlternateDisplayTotal { get; set; }
        public bool UseItemPriceForAlternateTotal { get; set; }
        public bool ForgiveAlternateTotalTaxOnSmartVat { get; set; }
        public bool UseFloridaCalculation { get; set; }
    }
}
