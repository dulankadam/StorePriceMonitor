using System;
using System.Collections.Generic;
using System.Text;

namespace StorePriceMonitor.Core.Services.PriceList.Query
{
    public class PriceListVM
    {
        public DateTime Time { get; set; }
        public Decimal Price { get; set; }
    }
}
