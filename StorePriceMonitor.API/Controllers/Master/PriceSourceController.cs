using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StorePriceMonitor.API.Controllers.Base;
using StorePriceMonitor.Core.Masters.PriceSource.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorePriceMonitor.API.Controllers.Master
{
    public class PriceSourceController : BaseApiController
    {
        [HttpGet("GetPriceSourceList")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<PriceSourceVM>>> Get()
        {
            return await Mediator.Send(new GetPriceSourceListQuery());            
        }
    }
}
