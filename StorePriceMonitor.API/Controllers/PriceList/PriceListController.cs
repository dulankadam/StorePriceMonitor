using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StorePriceMonitor.API.Controllers.Base;
using StorePriceMonitor.Core.Services.PriceList.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorePriceMonitor.API.Controllers.PriceList
{
    public class PriceListController : BaseApiController
    {
        [HttpPost("GetPriceList")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<PriceListVM>>> Create(GetPriceListQuery query)
        {
            return await Mediator.Send(query);
        }
    }
}
