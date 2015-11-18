using System;

namespace CSFPOSWare.Models
{
    public partial class CSEod : BaseModel
    {
        public Guid CSEodId { get; set; }
        public Nullable<decimal> NET_A_DailySales { get; set; }
        public Nullable<decimal> DAY_A_DeptSum { get; set; }
        public Nullable<decimal> TX_SAL_VATSales { get; set; }
        public Nullable<decimal> NX_SAL_ZeroNonVATSales { get; set; }
        public Nullable<decimal> TAX_A_VAT { get; set; }
        public Nullable<decimal> TAX_B_OtherTax { get; set; }
        public Nullable<decimal> SV_CHG_ServiceCharge { get; set; }
        public Nullable<decimal> OT_CHG_OtherCharges { get; set; }
        public Nullable<decimal> TotalDisc { get; set; }
        public Nullable<decimal> DIS_A_OtherDisc { get; set; }
        public Nullable<decimal> DIS_B_EmpDisc { get; set; }
        public Nullable<decimal> DIS_C_SeniorDisc { get; set; }
        public Nullable<decimal> DIS_D_VIPDisc { get; set; }
        public Nullable<decimal> DIS_E_PWDDisc { get; set; }
        public Nullable<decimal> DIS_F_GPCDisc { get; set; }
        public Nullable<decimal> DIS_G_Disc1 { get; set; }
        public Nullable<decimal> DIS_H_Disc2 { get; set; }
        public Nullable<decimal> DIS_I_Disc3 { get; set; }
        public Nullable<decimal> DIS_J_Disc4 { get; set; }
        public Nullable<decimal> DIS_K_Disc5 { get; set; }
        public Nullable<decimal> DIS_L_Disc6 { get; set; }
        public Nullable<decimal> TotalTender { get; set; }
        public Nullable<decimal> CSH_Cash { get; set; }
        public Nullable<decimal> GC_GiftCheque { get; set; }
        public Nullable<decimal> EPS_DebitCard { get; set; }
        public Nullable<decimal> TND_OtherTender { get; set; }
        public Nullable<decimal> MCRD_Mastercard { get; set; }
        public Nullable<decimal> VISA_Visa { get; set; }
        public Nullable<decimal> AMEX_AmericanExpress { get; set; }
        public Nullable<decimal> DINERS_DinersClub { get; set; }
        public Nullable<decimal> JCB_JCB { get; set; }
        public Nullable<decimal> OTCRD_OtherCard { get; set; }
        public Nullable<decimal> VOID { get; set; }
        public Nullable<decimal> RFND { get; set; }
        public Nullable<decimal> ADJ_A { get; set; }
        public Nullable<decimal> ADJ_POS { get; set; }
        public Nullable<decimal> ADJ_NEG { get; set; }
        public Nullable<decimal> ADJ_NT_POS { get; set; }
        public Nullable<decimal> ADJ_NT_NEG { get; set; }
        public Nullable<System.DateTime> CS_END_DATE { get; set; }
        public Nullable<decimal> CS_TND_EPLUS { get; set; }
        public Nullable<decimal> CS_TND_SMAC { get; set; }
        public Nullable<decimal> CS_TND_COUPON_VOUCHER { get; set; }
        public Nullable<decimal> CHG_ChargeSales { get; set; }
        public Nullable<decimal> CS_CC_TOTAL { get; set; }
        public Nullable<decimal> CS_TIP { get; set; }
        public Nullable<decimal> CS_EXCESS_GC { get; set; }
        public Nullable<decimal> CS_CUST_COUNT { get; set; }
        public Nullable<System.DateTime> DTE { get; set; }
        public Nullable<System.TimeSpan> TIME { get; set; }
        public Nullable<decimal> CS_TRANS_COUNT { get; set; }
        public Nullable<decimal> FT { get; set; }
        public Nullable<decimal> LT { get; set; }
        public Nullable<decimal> OLD_A { get; set; }
        public Nullable<decimal> NEW_A { get; set; }
        public Nullable<decimal> ZCNT { get; set; }
        public Nullable<decimal> CS_GROSS { get; set; }
    }
}
