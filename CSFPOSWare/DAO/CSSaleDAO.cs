using CSFPOSWare.Models;
using CSFPOSWare.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFPOSWare.DAO
{
    public class CSSaleDAO : BaseDAO
    {
        public CSSale get(Guid saleID)
        {
            using (context = new CSFPOSWareContext())
            {
                var query = from s in context.CSSales
                            where s.CSSaleID == saleID
                            select s;
                return query.FirstOrDefault();
            }
        }

        public void add(CSSale csSale)
        {
            using (context = new CSFPOSWareContext())
            {
                context.CSSales.Add(csSale);
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

        public void remove(CSSale csSale)
        {
            csSale = get(csSale.CSSaleID);
            using (context = new CSFPOSWareContext())
            {
                if (null != csSale)
                {
                    context.CSSales.Remove(csSale);
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
