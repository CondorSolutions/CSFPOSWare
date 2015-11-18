using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFPOSWare.Utils
{
    public class Util
    {
        public class Number
        {
            private static int fposPrecision = 100;//ex. 100.00 = 10000
            private static int fposWarePrecision = 10000;//ex. 100.00 = 1000000

            //public static int fposToFposWare(int fposNumber)
            //{
            //    return fposNumber / fposPrecision * fposWarePrecision;
            //}

            //public static int moneyToFposWare(double money)
            //{
            //    string str = (money * fposWarePrecision).ToString();
            //    if (str.IndexOf(".") > 0)
            //    {
            //        str = str.Substring(0, str.IndexOf("."));
            //    }
            //    return int.Parse(str);
            //}
            public static decimal fposToMoney(int fposNumber)
            {
                return fposNumber / fposPrecision;
            }
            //public static double fposWareToMoney(int fposWareNumber)
            //{
            //    return fposWareNumber / fposWarePrecision;
            //}

            public static string peso(string n)
            {
                if (n != null)
                {
                    double dbl = double.Parse(n);
                    n = dbl.ToString("N");
                    n = String.Format("\u20B1 {0}", n);
                }
                return n;
            }
        }
    }
}
