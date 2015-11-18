using CSFPOSWare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFPOSWare.DAO
{
    public class ItemDAO : BaseDAO
    {
        public Item get(string itemName)
        {
            using (context = new CSFPOSWareContext())
            {
                var query = from i in context.Items
                            where i.ItemName == itemName
                            select i;
                return query.FirstOrDefault();
            }
        }
    }
}