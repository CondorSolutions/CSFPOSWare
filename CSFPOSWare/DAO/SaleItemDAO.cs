using CSFPOSWare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFPOSWare.DAO
{
    public class SaleItemDAO : BaseDAO
    {
        public List<SaleItem> find(string saleID)
        {
            using (context = new CSFPOSWareContext())
            {
                var query = from si in context.SaleItems
                            where si.SaleID.ToString() == saleID
                            orderby si.ItemIndex
                            select si;
                //Logger.log.Debug(query.Expression.ToString());
                //Logger.log.Debug(query.First().SaleID.ToString());
                //foreach (var s in query)
                //{
                //    Logger.log.Debug(s.SaleID);
                //}
                return query.ToList<SaleItem>();
            }
        }
    }
}
