using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Lannister.Controllers
{
    [Produces("application/json")]
    [Route("trackings/{trackingId}/transfers")]
    public class TrackingTransfersController : Controller
    {
        public TrackingTransfersController()
        {

        }

        [HttpPost]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult CreateTransfer([FromRoute] int trackingId)
        {
            return Ok();
        }

        [HttpGet]
        [Route("{transferId}")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult GetTransfer([FromRoute] int trackingId, [FromRoute] int transferId)
        {
            return Ok($"Create transfer {transferId} for tracking {trackingId}");
        }

        [HttpPut]
        [Route("{transferId}")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult UpdateTransfer([FromRoute] int trackingId, [FromRoute] int transferId)
        {
            return Ok($"Update transfer {transferId} for tracking {trackingId}");
        }

        [HttpDelete]
        [Route("{transferId}")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult DeleteTransfer([FromRoute] int trackingId, [FromRoute] int transferId)
        {
            return Ok($"Delete transfer {transferId} for tracking {trackingId}");
        }

        //accepts query string with limit and offset parameters for pagination
        [HttpGet]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult GetTransfers([FromRoute] int trackingId,
                   [FromQuery] int limit, [FromQuery] int offset)
        {
            return Ok();
        }
    }
}
