using CSFPOSWare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFPOSWare.DAO
{
    /// <summary>
    /// this class will be widely e used to access dbo.Sale and dbo.CSSale tables and other related objects
    /// </summary>
    public class SaleDAO : BaseDAO
    {
        public Sale get(Guid saleID)
        {
            using (context = new CSFPOSWareContext())//found in BaseDAO
            {
                var query = from s in context.Sales
                            where s.IsSuspend.Equals(true) //bit converts to boolean
                            where s.IsRetrieved.Equals(1) //but tinyint does not. @#$%!!@#
                            select s;
                //Logger.log.Debug(query.Expression.ToString());
                //Logger.log.Debug(query.First().SaleID.ToString());
                //foreach (var s in query)
                //{
                //    Logger.log.Debug(s.SaleID);
                //}
                return query.FirstOrDefault();
            }
        }

        public Sale getById(Guid saleID)
        {
            using (context = new CSFPOSWareContext())//found in BaseDAO
            {
                var query = from s in context.Sales
                            where s.SaleID.Equals(saleID)
                            select s;
                //Logger.log.Debug(query.Expression.ToString());
                //Logger.log.Debug(query.First().SaleID.ToString());
                //foreach (var s in query)
                //{
                //    Logger.log.Debug(s.SaleID);
                //}
                return query.FirstOrDefault();
            }
        }
    }
}