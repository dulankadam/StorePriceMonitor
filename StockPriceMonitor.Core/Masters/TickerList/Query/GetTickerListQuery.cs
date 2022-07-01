using MediatR;
using Microsoft.EntityFrameworkCore;
using StorePriceMonitor.Core.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StorePriceMonitor.Core.Masters.TickerList.Query
{
    public class GetTickerListQuery : IRequest<List<TickerListVM>>
    {
    }

    public class GetTickerListQueryHandler : IRequestHandler<GetTickerListQuery, List<TickerListVM>>
    {
        private readonly IApplicationDbContext _context;
        public GetTickerListQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public Task<List<TickerListVM>> Handle(GetTickerListQuery request, CancellationToken cancellationToken)
        {
            var TickerList = _context.TickerLists.Select(r => new TickerListVM { Id = r.Id, Description = r.Description }).ToListAsync();
            return TickerList;
        }
    }
}
