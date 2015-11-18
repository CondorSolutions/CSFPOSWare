using CSFPOSWare.Models;
using CSFPOSWare.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFPOSWare.DAO
{
    public class CSSaleItemTaxDAO : BaseDAO
    {
        public CSSaleItemTax get(Guid csSaleItemTaxID)
        {
            using (context = new CSFPOSWareContext())
            {
                var query = from s in context.CSSaleItemTaxes
                            where s.CSSaleItemTaxID == csSaleItemTaxID
                            select s;
                return query.FirstOrDefault();
            }
        }

        public List<CSSaleItemTax> findBySaleItem(Guid saleItemID)
        {
            List<CSSaleItemTax> CSSaleItemTaxList = null;
            using (context = new CSFPOSWareContext())
            {
                var query = from sit in context.CSSaleItemTaxes
                            where sit.CSSaleItemID == saleItemID
                            select sit;
                try
                {
                    CSSaleItemTaxList = query.ToList();
                }
                catch (Exception e)
                {
                    //Logger.log.Error(e.Message);
                    //Logger.log.Error(e.StackTrace);
                }
                return CSSaleItemTaxList;
            }
        }

        public void add(CSSaleItemTax csSaleItemTax)
        {
            using (context = new CSFPOSWareContext())
            {
                context.CSSaleItemTaxes.Add(csSaleItemTax);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    Logger.log.Error(e.Message);
                    Logger.log.Error(e.StackTrace);
                }
            }
        }

        public void remove(CSSaleItemTax csSaleItemTax)
        {
            csSaleItemTax = get(csSaleItemTax.CSSaleItemTaxID);
            using (context = new CSFPOSWareContext())
            {
                if (null != csSaleItemTax)
                {
                    context.CSSaleItemTaxes.Remove(csSaleItemTax);
                    try
                    {
                        context.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        Logger.log.Error(e.Message);
                        Logger.log.Error(e.StackTrace);
                        Logger.log.Error(e.InnerException.StackTrace);
                    }
                }
            }
        }
        //public void removeBySaleItem(SaleItem saleItem)
        //{
        //    List<CSSaleItemTax> CSSaleItemTaxes = findBySaleItem(saleItem.SaleItemID);

        //    if (CSSaleItemTaxes != null)
        //    {
        //        using (context = new CSFPOSWareContext())
        //        {
        //            foreach (CSSaleItemTax csSaleItemTax in CSSaleItemTaxes)
        //            {
        //                Logger.log.Debug("deleting CSSaleItemTaxes...");
        //                context.CSSaleItemTaxes.Remove(csSaleItemTax);
        //                try
        //                {
        //                    context.SaveChanges();
        //                }
        //                catch (Exception e)
        //                {
        //                    Logger.log.Error(e.Message);
        //                    Logger.log.Error(e.StackTrace);
        //                    Logger.log.Error(e.InnerException.StackTrace);
        //                }
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Logger.log.Debug("no CSSaleItemTaxes to delete");
        //    }
        //}

        public void removeBySaleItem(CSSaleItem csSaleItem)
        {
            List<CSSaleItemTax> CSSaleItemTaxList = null;
            using (context = new CSFPOSWareContext())
            {
                var query = from sit in context.CSSaleItemTaxes
                            where sit.CSSaleItemID == csSaleItem.CSSaleItemID
                            select sit;
                CSSaleItemTaxList = query.ToList();
            }

            using (context = new CSFPOSWareContext())
            {
                foreach (CSSaleItemTax CSSaleItemTax in CSSaleItemTaxList)
                {
                    context.CSSaleItemTaxes.Remove(CSSaleItemTax);
                    context.SaveChanges();
                }
            }
        }
    }
}