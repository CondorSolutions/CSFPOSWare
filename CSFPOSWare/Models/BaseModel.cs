using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSFPOSWare.Models
{
    public partial class BaseModel
    {
        public static string ToString(object o)
        {
            string str = "";
            PropertyInfo[] properties = o.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                str += property.Name + "=";
                str += o.GetType().GetProperty(property.Name).GetValue(o, null);
                str += " | ";
            }
            return str;
        }
    }
}
