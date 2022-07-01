using MediatR;
using Microsoft.EntityFrameworkCore;
using StorePriceMonitor.Core.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StorePriceMonitor.Core.Services.PriceList.Query
{
    public class GetPriceListQuery : IRequest<List<PriceListVM>>
    {
        public int PriceListId { get; set; }
        public int TickerId { get; set; }
    }

    public class GetPriceListQueryHandler : IRequestHandler<GetPriceListQuery, List<PriceListVM>>
    {
        private readonly IApplicationDbContext _context;
        public GetPriceListQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<PriceListVM>> Handle(GetPriceListQuery request, CancellationToken cancellationToken)
        {
            var priceList = await _context.PriceLists
                                .Where(p => p.TickerListId == request.TickerId && p.PriceSourceId == request.PriceListId)
                                .OrderByDescending(o=> o.Id)
                                .Take(5)
                                .Select(p => new PriceListVM { Time= p.Time, Price = p.Price})
                                .ToListAsync();

            return priceList;
        }
    }

}
