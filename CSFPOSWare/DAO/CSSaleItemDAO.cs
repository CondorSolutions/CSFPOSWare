using CSFPOSWare.Models;
using CSFPOSWare.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFPOSWare.DAO
{
    public class CSSaleItemDAO : BaseDAO
    {
        public CSSaleItem get(Guid saleItemID)
        {
            CSSaleItem CSSaleItem = null;
            using (context = new CSFPOSWareContext())
            {
                var query = from s in context.CSSaleItems
                            where s.CSSaleItemID == saleItemID
                            select s;
                //return query.FirstOrDefault();
                try
                {
                    CSSaleItem = query.FirstOrDefault();
                }
                catch (Exception e)
                {
                    Logger.log.Error(e.Message);
                    Logger.log.Error(e.StackTrace);
                }
                return CSSaleItem;
            }
        }

        public void add(CSSaleItem csSaleItem)
        {
            using (context = new CSFPOSWareContext())
            {
                context.CSSaleItems.Add(csSaleItem);
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

        public List<CSSaleItem> removeByCSSale(CSSale CSSale)
        {
            List<CSSaleItem> CSSaleItemList = null;
            using (context = new CSFPOSWareContext())
            {
                var query = from si in context.CSSaleItems
                            where si.CSSaleID == CSSale.CSSaleID
                            select si;
                CSSaleItemList = query.ToList();
            }

            using (context = new CSFPOSWareContext())
            {
                foreach (CSSaleItem CSSaleItem in CSSaleItemList)
                {
                    context.CSSaleItems.Remove(CSSaleItem);
                    context.SaveChanges();
                }
            }
            return CSSaleItemList;
        }

        public void remove(CSSaleItem csSaleItem)
        {
            csSaleItem = get(csSaleItem.CSSaleItemID);
            using (context = new CSFPOSWareContext())
            {
                if (null != csSaleItem)
                {
                    context.CSSaleItems.Remove(csSaleItem);
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
    }
}
