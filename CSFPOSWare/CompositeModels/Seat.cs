using CSFPOSWare.Models;
using System.Collections.Generic;

namespace CSFPOSWare.CompositeModels
{
    public class Seat
    {
        public int number { get; set; }
        public List<SaleItem> saleItems { get; set; }
        public List<CSSaleItem> csSaleItems { get; set; }
        public bool ignorePrint { get; set; }
    }
}