
using CSFPOSWare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFPOSWare.DAO
{
    public class CSConfigurationDAO : BaseDAO
    {
        public CSConfiguration get(string section, string parameter)
        {
            using (context = new CSFPOSWareContext())
            {
                var query = from c in context.CSConfigurations
                            where c.Section == section
                            where c.Parameter == parameter
                            select c;
                return query.FirstOrDefault();
            }
        }
    }
}