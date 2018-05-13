using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Lannister.Controllers
{
    /// <summary>
    /// Contains all actions with checkouts
    /// </summary>
    [Produces("application/json")]
    [Route("trackings/{trackingId}/checkouts")]
    public class TrackingCheckoutsController : Controller
    {
        public TrackingCheckoutsController()
        {

        }

        /// <summary>
        /// Create new checkout for the tracking
        /// </summary>
        /// <param name="trackingId"></param>
        /// <returns></returns>
        [HttpPost]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult CreateCheckout([FromRoute] int trackingId)
        {
            return Ok();
        }

        /// <summary>
        /// Get selected tracking checkout fields
        /// </summary>
        /// <param name="trackingId"></param>
        /// <param name="checkoutId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{checkoutId}")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult GetCheckout([FromRoute] int trackingId, [FromRoute] int checkoutId)
        {
            return Ok();
        }

        /// <summary>
        /// Change selected tracking checkout
        /// </summary>
        /// <param name="trackingId"></param>
        /// <param name="checkoutId"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{checkoutId}")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult UpdateCheckout([FromRoute] int trackingId, [FromRoute] int checkoutId)
        {
            return Ok();
        }

        /// <summary>
        /// Delete selected tracking checkout
        /// </summary>
        /// <param name="trackingId"></param>
        /// <param name="checkoutId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{checkoutId}")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult DeleteCheckout([FromRoute] int trackingId, [FromRoute] int checkoutId)
        {
            return Ok();
        }

        /// <summary>
        /// Get all tracking checkouts
        /// </summary>
        /// <param name="trackingId"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        [HttpGet]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult GetCheckouts([FromRoute] int trackingId, 
                   [FromQuery] int limit, [FromQuery] int offset)
        {
            return Ok();
        }
    }
}
