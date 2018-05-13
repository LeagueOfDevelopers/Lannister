using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Lannister.Controllers
{
    /// <summary>
    /// Contains all actions with transfers
    /// </summary>
    [Produces("application/json")]
    [Route("trackings/{trackingId}/transfers")]
    public class TrackingTransfersController : Controller
    {
        public TrackingTransfersController()
        {

        }

        /// <summary>
        /// Create new transfer for the tracking
        /// </summary>
        /// <param name="trackingId"></param>
        /// <returns></returns>
        [HttpPost]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult CreateTransfer([FromRoute] int trackingId)
        {
            return Ok();
        }

        /// <summary>
        /// Get selected transfer checkout fields
        /// </summary>
        /// <param name="trackingId"></param>
        /// <param name="transferId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{transferId}")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult GetTransfer([FromRoute] int trackingId, [FromRoute] int transferId)
        {
            return Ok();
        }

        /// <summary>
        /// Change selected tracking transfer
        /// </summary>
        /// <param name="trackingId"></param>
        /// <param name="transferId"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{transferId}")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult UpdateTransfer([FromRoute] int trackingId, [FromRoute] int transferId)
        {
            return Ok();
        }

        /// <summary>
        /// Delete selected tracking transfer
        /// </summary>
        /// <param name="trackingId"></param>
        /// <param name="transferId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{transferId}")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult DeleteTransfer([FromRoute] int trackingId, [FromRoute] int transferId)
        {
            return Ok();
        }

        /// <summary>
        /// Get all tracking transfers
        /// </summary>
        /// <param name="trackingId"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
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
