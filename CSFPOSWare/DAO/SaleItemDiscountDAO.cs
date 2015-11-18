using CSFPOSWare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFPOSWare.DAO
{
    public class SaleItemDiscountDAO : BaseDAO
    {
        public List<SaleItemDiscount> find(string saleItemID)
        {
            using (context = new CSFPOSWareContext())
            {
                var query = from sid in context.SaleItemDiscounts
                            where sid.SaleItemID.ToString() == saleItemID
                            select sid;
                return query.ToList<SaleItemDiscount>();
            }
        }
    }
}
