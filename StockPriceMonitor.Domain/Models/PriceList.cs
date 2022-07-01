using System;
using System.Collections.Generic;
using System.Text;

namespace StorePriceMonitor.Domain.Models
{
    public class PriceList:ModelBase
    {
        public DateTime Time { get; set; }
        public Decimal Price { get; set; }
        
        public int PriceSourceId { get; set; }
        public virtual PriceSource PriceSource { get; set; }
        public int TickerListId { get; set; }
        public virtual TickerList TickerList { get; set; }
        public bool Status { get; set; }
    }
}
