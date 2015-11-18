using CSFPOSWare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFPOSWare.DAO
{
    public class MaintenanceDAO : BaseDAO
    {
        public List<Discount> getDiscounts()
        {
            using (context = new CSFPOSWareContext())
            {
                var query = from d in context.Discounts
                            orderby d.DiscountIndex
                            select d;
                return query.ToList();
            }
        }

        public List<Media> getMedia()
        {
            using (context = new CSFPOSWareContext())
            {
                var query = from m in context.Medias
                            orderby m.MediaIndex
                            select m;
                return query.ToList();
            }
        }
    }
}
