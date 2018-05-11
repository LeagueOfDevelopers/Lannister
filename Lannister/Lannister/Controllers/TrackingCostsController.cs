using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Lannister.Controllers
{
    [Produces("application/json")]
    [Route("trackings/{trackingId}/costs")]
    public class TrackingCostsController : Controller
    {
        public TrackingCostsController()
        {

        }

        [HttpPost]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult CreateCost([FromRoute] int trackingId)
        {
            return Ok();
        }

        [HttpGet]
        [Route("{costId}")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult GetCost([FromRoute] int trackingId, [FromRoute] int costId)
        {
            return Ok($"Create cost {costId} for tracking {trackingId}");
        }

        [HttpPut]
        [Route("{costId}")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult UpdateCost([FromRoute] int trackingId, [FromRoute] int costId)
        {
            return Ok($"Update cost {costId} for tracking {trackingId}");
        }

        [HttpDelete]
        [Route("{costId}")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult DeleteCost([FromRoute] int trackingId, [FromRoute] int costId)
        {
            return Ok($"Delete cost {costId} for tracking {trackingId}");
        }

        //accepts query string with limit and offset parameters for pagination
        [HttpGet]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult GetCosts([FromRoute] int trackingId, 
                   [FromQuery] int limit, [FromQuery] int offset)
        {
            return Ok();
        }
    }
}
