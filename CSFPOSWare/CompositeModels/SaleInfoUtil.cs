using CSFPOSWare.DAO;
using CSFPOSWare.Models;
using CSFPOSWare.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFPOSWare.CompositeModels
{
    public class SaleInfoUtil
    {
        private MaintenanceDAO maintenanceDAO = null;
        //public void tester()
        //{
        //    CSSaleItemTaxDAO CSSaleItemTaxDAO = new CSSaleItemTaxDAO();
        //    List<CSSaleItemTax> CSSaleItemTaxList = CSSaleItemTaxDAO.findBySaleItem(new Guid("8B5B9A72-1189-E511-8FCE-00E04C5A69F7"));

        //    //Logger.log.Debug(CSSaleItemTaxList.Count);
        //    Logger.log.Debug(CSSaleItemTaxDAO.get(new Guid("FB070CD7-268C-4F78-ACD2-08D2EC07B9A5")).Amount);

        //    SaleDAO saleDao = new SaleDAO();
        //    Logger.log.Debug(saleDao.getById(new Guid("EFDCC0DB-6384-E511-8CE4-00E04C5A69F7")).CheckNumber);

        //    CSSaleDAO CSSaleDAO = new CSSaleDAO();
        //    Logger.log.Debug(CSSaleDAO.get(new Guid("775B9A72-1189-E511-8FCE-00E04C5A69F7")).CheckNo);
        //}

        public CSSale getSaleInfo(string saleID = "")
        {
            //1. get Sale
            SaleDAO saleDAO = new SaleDAO();
            Sale sale = saleDAO.get(new Guid());//fix this next time
            // Sale sale = saleDAO.getById(new Guid(saleID));
            CSSale csSale = null;
            if (null == sale)
            {
                Logger.log.Info("No sale info found.");
            }
            else
            {
                //2. check if CSSale exists
                CSSaleDAO csSaleDAO = new CSSaleDAO();
                csSale = csSaleDAO.get(sale.SaleID);
                if (null == csSale)
                {
                    Logger.log.Debug("csSale not found; do _buildCSSale...");
                    csSale = _buildCSSale(sale);
                }
                else
                {
                    Logger.log.Debug(csSale.ORNo == null);
                    Logger.log.Debug("csSale found.");
                    // Logger.log.Debug(csSale.CSSaleItems);
                    if (csSale.ORNo == null)
                    {//rebuild
                        csSale = _buildCSSale(sale);
                    }
                    else
                    {
                        Logger.log.Debug("csSale final.");
                    }
                }
            }
            return csSale;
        }

        private CSSale _buildCSSale(Sale sale)
        {
            CSSale csSale = null;
            maintenanceDAO = new MaintenanceDAO();
            int totalItems = 0;
            SaleInfo saleInfo = new SaleInfo();
            saleInfo.seats = new List<Seat>();
            SaleItemDAO saleItemDAO = new SaleItemDAO();
            Seat currentSeat = new Seat();
            foreach (SaleItem saleItem in saleItemDAO.find(sale.SaleID.ToString()))
            {
                Console.WriteLine(saleItem.ToString());
                if (saleItem.Flags == 4 || saleItem.Flags == 20)//it's a seat!
                {
                    Seat seat = new Seat();
                    currentSeat = seat;
                    seat.saleItems = new List<SaleItem>();
                    seat.number = saleItem.BasePrice;
                    saleInfo.seats.Add(seat);
                    Logger.log.Debug("seat #" + seat.number + " added");
                    if (saleItem.Flags == 20)
                        currentSeat.ignorePrint = true;
                }
                else//it's an item
                {
                    if (!currentSeat.ignorePrint)
                    {
                        currentSeat.saleItems.Add(saleItem);
                        totalItems++;
                        Logger.log.Debug("item " + saleItem.ItemName + " added to seat #" + currentSeat.number);
                    }
                }
            }

            if (totalItems > 0)
            {
                csSale = new CSSale();
                csSale.CSSaleID = sale.SaleID;
                csSale.CheckNo = sale.CheckNumber;
                csSale.EndDate = DateTime.Now;
                //replace csSale data
                _clearCSSale(csSale);
                _buildCSSaleItem(saleInfo.seats);
                CSSaleDAO csSaleDAO = new CSSaleDAO();
                csSaleDAO.add(csSale);
                //build CSSale data
                //1. TOTALS
                int totalDisc = 0;
                foreach (Seat seat in saleInfo.seats)
                {
                    foreach (CSSaleItem csSaleItem in seat.csSaleItems)
                    {
                        //1.1. discounts
                    }
                }
            }
            else
            {
                Logger.log.Info("No Items found.");
            }
            return csSale;
        }
        private void _clearCSSale(CSSale csSale)
        {
            CSSaleDAO csSaleDAO = new CSSaleDAO();
            csSaleDAO.remove(csSale);
            CSSaleItemDAO csSaleItemDAO = new CSSaleItemDAO();
            List<CSSaleItem> CSSaleItemList = csSaleItemDAO.removeByCSSale(csSale);
            CSSaleItemDiscountDAO CSSaleItemDiscountDAO = new CSSaleItemDiscountDAO();
            CSSaleItemTaxDAO CSSaleItemTaxDAO = new CSSaleItemTaxDAO();
            foreach (CSSaleItem csSaleItem in CSSaleItemList)
            {
                CSSaleItemDiscountDAO.removeBySaleItem(csSaleItem);
                CSSaleItemTaxDAO.removeBySaleItem(csSaleItem);
            }
        }

        private void _buildCSSaleItem(List<Seat> seats)
        {
            List<Discount> discounts = maintenanceDAO.getDiscounts();
            //Logger.log.Debug(discounts);
            SaleItemDiscountDAO saleItemDiscountDAO = new SaleItemDiscountDAO();
            ItemDAO itemDAO = new ItemDAO();
            foreach (Seat seat in seats)
            {
                seat.csSaleItems = new List<CSSaleItem>();
                foreach (SaleItem saleItem in seat.saleItems)
                {
                    Item item = itemDAO.get(saleItem.ItemName);
                    //Logger.log.Debug(BaseModel.ToString(saleItem));
                    List<SaleItemDiscount> saleItemDiscounts = saleItemDiscountDAO.find(saleItem.SaleItemID.ToString());
                    //double discountAmount = 0;
                    decimal vatableAmount = Util.Number.fposToMoney(saleItem.BasePrice);
                    decimal vatableTax = Util.Number.fposToMoney(saleItem.BasePrice) / new decimal(1.12) * new decimal(0.12);
                    decimal vatExemptAmount = 0;
                    decimal vatExemptTax = 0;
                    decimal zeroRatedAmount = 0;
                    decimal zeroRatedtax = 0;



                    decimal amountDue = Util.Number.fposToMoney(saleItem.BasePrice);
                    bool hasSCDisc = false;
                    bool hasPWDDisc = false;

                    foreach (SaleItemDiscount saleItemDiscount in saleItemDiscounts)
                    {
                        Logger.log.Debug(saleItem.ItemName + " discountIndex : " + saleItemDiscount.DiscountIndex);
                        CSConfigurationDAO csConfigurationDAO = new CSConfigurationDAO();
                        int PWDMapIndex = int.Parse(csConfigurationDAO.get(CSConfiguration.Sections.DiscountIndexMap, CSConfiguration.Parameters.PWDIndex).Value);
                        int SeniorMapIndex = int.Parse(csConfigurationDAO.get(CSConfiguration.Sections.DiscountIndexMap, CSConfiguration.Parameters.SeniorIndex).Value);

                        Discount currDiscount = discounts[saleItemDiscount.DiscountIndex];

                        decimal discountAmount = 0;
                        if (saleItemDiscount.DiscountIndex == SeniorMapIndex)
                        {//Senior - refer to this file for computation : https://condorsolutions.slack.com/files/otalusan/F0E994FEK/senior_discount_computation.txt
                            discountAmount += (Util.Number.fposToMoney(saleItem.BasePrice) / new decimal(1.12)) * currDiscount.PercentOff / 10000;
                            vatableAmount = 0;
                            vatableTax = 0;
                            vatExemptAmount = Util.Number.fposToMoney(saleItem.BasePrice);
                            vatExemptTax = Util.Number.fposToMoney(saleItem.BasePrice) / new decimal(1.12) * new decimal(0.12);
                            amountDue -= discountAmount;
                        }
                        else if (saleItemDiscount.DiscountIndex == PWDMapIndex)
                        {//PWD
                            if (Main.GlobalValues.mallSetup.Equals(CSConfiguration.Values.Megaworld))
                            {//Megaworld setup
                                discountAmount += Util.Number.fposToMoney(saleItem.BasePrice) * currDiscount.PercentOff / 10000;
                                vatableAmount = Util.Number.fposToMoney(saleItem.BasePrice);
                                vatableTax = Util.Number.fposToMoney(saleItem.BasePrice) / new decimal(1.12) * new decimal(0.12);
                                amountDue -= discountAmount;
                            }
                            else if (Main.GlobalValues.mallSetup.Equals(CSConfiguration.Values.SM))
                            {//SM setup
                                discountAmount += Util.Number.fposToMoney(saleItem.BasePrice) / new decimal(1.12) * currDiscount.PercentOff / 10000;
                                decimal pwdAmountDue = amountDue - Util.Number.fposToMoney(saleItem.BasePrice) * currDiscount.PercentOff / 10000;
                                vatableAmount = pwdAmountDue;
                                vatableTax = pwdAmountDue / new decimal(1.12) * new decimal(0.12);
                                amountDue -= Util.Number.fposToMoney(saleItem.BasePrice) * currDiscount.PercentOff / 10000;
                            }
                        }
                        else //other discounts not PWD and Senior
                        {
                            vatableAmount = Util.Number.fposToMoney(saleItem.BasePrice);
                            vatableTax = Util.Number.fposToMoney(saleItem.BasePrice) / new decimal(1.12) * new decimal(0.12);
                            discountAmount += Util.Number.fposToMoney(saleItemDiscount.Amount);
                            amountDue -= discountAmount;
                        }

                        //TODO: otalusan: Zero-rated items
                        if (item.TaxFlags == 4)
                        {
                            Logger.log.Info("TODO: otalusan: Zero-rated items");
                        }
                        CSSaleItemDiscount csSaleItemDiscount = new CSSaleItemDiscount();
                        csSaleItemDiscount.CSSaleItemDiscountID = saleItemDiscount.SaleItemDiscountID;
                        csSaleItemDiscount.CSSaleItemID = saleItemDiscount.SaleItemID;
                        csSaleItemDiscount.ItemIndex = saleItemDiscount.ItemIndex;
                        csSaleItemDiscount.DiscountName = currDiscount.DiscountName;
                        csSaleItemDiscount.Amount = discountAmount;

                        CSSaleItemDiscountDAO csSaleItemDiscountDAO = new CSSaleItemDiscountDAO();
                        Logger.log.Debug(BaseModel.ToString(csSaleItemDiscount));
                        //csSaleItemDiscountDAO.remove(csSaleItemDiscount);
                        csSaleItemDiscountDAO.add(csSaleItemDiscount);
                        break;//Apply only ONE discount
                    }//foreach(SaleItemDiscount saleItemDiscount in saleItemDiscounts)

                    CSSaleItemTaxDAO csSaleItemTaxDAO = new CSSaleItemTaxDAO();
                    // csSaleItemTaxDAO.removeBySaleItem(saleItem);//cleanup

                    //1. VAT sales
                    CSSaleItemTax csSaleItemTaxVAT = new CSSaleItemTax();
                    csSaleItemTaxVAT.CSSaleItemID = saleItem.SaleItemID;
                    csSaleItemTaxVAT.Type = CSSaleItemTax.Types.VAT;
                    csSaleItemTaxVAT.Amount = vatableAmount;
                    csSaleItemTaxVAT.Tax = vatableTax;
                    if (csSaleItemTaxVAT.Amount > 0)
                        csSaleItemTaxDAO.add(csSaleItemTaxVAT);
                    //2. VAT exempt sales
                    CSSaleItemTax csSaleItemTaxVATExempt = new CSSaleItemTax();
                    csSaleItemTaxVATExempt.CSSaleItemID = saleItem.SaleItemID;
                    csSaleItemTaxVATExempt.Type = CSSaleItemTax.Types.VATExempt;
                    csSaleItemTaxVATExempt.Amount = vatExemptAmount;
                    csSaleItemTaxVATExempt.Tax = vatExemptTax;
                    if (csSaleItemTaxVATExempt.Amount > 0)
                        csSaleItemTaxDAO.add(csSaleItemTaxVATExempt);
                    //3. Zero-rated sales
                    CSSaleItemTax csSaleItemTaxZero = new CSSaleItemTax();
                    csSaleItemTaxZero.CSSaleItemID = saleItem.SaleItemID;
                    csSaleItemTaxZero.Type = CSSaleItemTax.Types.ZERORated;
                    csSaleItemTaxZero.Amount = zeroRatedAmount;
                    csSaleItemTaxZero.Tax = zeroRatedtax;
                    if (csSaleItemTaxZero.Amount > 0)
                        csSaleItemTaxDAO.add(csSaleItemTaxZero);
                    //TODO: otalusan - local and other taxes
                    //4. Local tax
                    CSSaleItemTax csSaleItemLocalTax = new CSSaleItemTax();
                    csSaleItemLocalTax.CSSaleItemID = saleItem.SaleItemID;
                    csSaleItemLocalTax.Type = CSSaleItemTax.Types.Local;

                    //5. Other taxes
                    CSSaleItemTax csSaleItemOtherTax = new CSSaleItemTax();
                    csSaleItemOtherTax.CSSaleItemID = saleItem.SaleItemID;
                    csSaleItemOtherTax.Type = CSSaleItemTax.Types.Other;

                    //build CSSaleItem - all amounts computed for
                    CSSaleItem csSaleItem = new CSSaleItem();
                    csSaleItem.CSSaleItemID = saleItem.SaleItemID;
                    csSaleItem.CSSaleID = saleItem.SaleID;
                    csSaleItem.ItemName = saleItem.ItemName;

                    csSaleItem.SeatNumber = seat.number;
                    csSaleItem.BasePrice = saleItem.BasePrice / 100;
                    csSaleItem.Quantity = saleItem.Quantity;
                    csSaleItem.AmountDue = amountDue;

                    //csSaleItem.vatableAmount = Util.Number.moneyToFposWare(vatableAmount);
                    //csSaleItem.vatableTax = Util.Number.moneyToFposWare(vatableTax);
                    //csSaleItem.vatExemptAmount = Util.Number.moneyToFposWare(vatExemptAmount);
                    //csSaleItem.vatExemptTax = Util.Number.moneyToFposWare(vatExemptTax);
                    //csSaleItem.zeroRatedAmount = Util.Number.moneyToFposWare(zeroRatedAmount);
                    //csSaleItem.zeroRatedtax = Util.Number.moneyToFposWare(zeroRatedtax);

                    CSSaleItemDAO csSaleItemDAO = new CSSaleItemDAO();
                    // csSaleItemDAO.remove(csSaleItem);
                    csSaleItemDAO.add(csSaleItem);
                    seat.csSaleItems.Add(csSaleItem);
                }//foreach(SaleItem saleItem in seat.saleItems)
            }//foreach(Seat seat in saleInfo.seats)
        }
    }
}
