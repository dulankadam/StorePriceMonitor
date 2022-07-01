using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorePriceMonitor.Core.Masters.PriceSource.Query
{
    public class PriceSourceVM : IRequest<bool>
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
