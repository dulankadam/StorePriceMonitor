using System;
using System.Collections.Generic;
using System.Text;

namespace StorePriceMonitor.Domain.Models
{
    public class ModelBase
    {
        public int Id { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string CreatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string UpdatedUser { get; set; }
    }
}
