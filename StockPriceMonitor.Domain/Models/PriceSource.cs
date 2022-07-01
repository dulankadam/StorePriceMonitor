using System;
using System.Collections.Generic;
using System.Text;

namespace StorePriceMonitor.Domain.Models
{
    public class PriceSource : ModelBase
    {
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
