using CSFPOSWare.Models;
using CSFPOSWare.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFPOSWare.DAO
{
    public class CSSaleItemDiscountDAO : BaseDAO
    {
        public CSSaleItemDiscount get(Guid csSaleItemDiscountID)
        {
            CSSaleItemDiscount CSSaleItemDiscount = null;
            using (context = new CSFPOSWareContext())
            {
                var query = from d in context.CSSaleItemDiscounts
                            where d.CSSaleItemDiscountID == csSaleItemDiscountID
                            select d;
                try
                {
                    CSSaleItemDiscount = query.FirstOrDefault();
                }
                catch (Exception e)
                {
                    //Logger.log.Error(e.Message);
                    //Logger.log.Error(e.StackTrace);
                }
                return CSSaleItemDiscount;
            }
        }

        public void add(CSSaleItemDiscount csSaleItemDiscount)
        {
            using (context = new CSFPOSWareContext())
            {
                context.CSSaleItemDiscounts.Add(csSaleItemDiscount);
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

        public void remove(CSSaleItemDiscount csSaleItemDiscount)
        {
            csSaleItemDiscount = get(csSaleItemDiscount.CSSaleItemDiscountID);
            if (null != csSaleItemDiscount)
            {
                using (context = new CSFPOSWareContext())
                {
                    context.CSSaleItemDiscounts.Remove(csSaleItemDiscount);
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

        public void removeBySaleItem(CSSaleItem csSaleItem)
        {
            List<CSSaleItemDiscount> CSSaleItemDiscountList = null;
            using (context = new CSFPOSWareContext())
            {
                var query = from sid in context.CSSaleItemDiscounts
                            where sid.CSSaleItemID == csSaleItem.CSSaleItemID
                            select sid;
                CSSaleItemDiscountList = query.ToList();
            }

            using (context = new CSFPOSWareContext())
            {
                foreach (CSSaleItemDiscount CSSaleItemDiscount in CSSaleItemDiscountList)
                {
                    context.CSSaleItemDiscounts.Remove(CSSaleItemDiscount);
                    context.SaveChanges();
                }
            }
        }
    }
}
