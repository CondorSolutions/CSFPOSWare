using CSFPOSWare.Models;
using System.Collections.Generic;

namespace CSFPOSWare.CompositeModels
{
    public class SaleInfo : CSSale
    {
        public List<Seat> seats { get; set; }
    }
}