using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StorePriceMonitor.API.Controllers.Base;
using StorePriceMonitor.Core.Masters.TickerList.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorePriceMonitor.API.Controllers.Master
{
    public class TickerController : BaseApiController
    {
        [HttpGet("GetTickerList")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<TickerListVM>>> Get()
        {
            return await Mediator.Send(new GetTickerListQuery());
        }
    }
}
