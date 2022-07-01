using MediatR;
using Microsoft.EntityFrameworkCore;
using StorePriceMonitor.Core.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StorePriceMonitor.Core.Masters.PriceSource.Query
{
    public class GetPriceSourceListQuery : IRequest<List<PriceSourceVM>>
    {

    }

    public class GetPriceSourceListQueryHandler : IRequestHandler<GetPriceSourceListQuery, List<PriceSourceVM>>
    {
        private readonly IApplicationDbContext _context;

        public GetPriceSourceListQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public Task<List<PriceSourceVM>> Handle(GetPriceSourceListQuery request, CancellationToken cancellationToken)
        {
            var PriceSourceList = _context.PriceSources.Select (r => new PriceSourceVM { Id = r.Id, Description = r.Description}).ToListAsync();
            return PriceSourceList;
        }
    }
}
