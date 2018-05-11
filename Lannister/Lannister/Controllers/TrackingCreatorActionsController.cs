using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Lannister.Controllers
{
    /// <summary>
    /// Contains only the actions available to creators
    /// </summary>
    [Produces("application/json")]
    [Route("trackings")]
    public class TrackingCreatorActionsController : Controller
    {
        public TrackingCreatorActionsController()
        {

        }

        [HttpPost]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult CreateTracking()
        {
            return Ok();
        }

        [HttpPost]
        [Route("{id}/disable")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult DisableTracking([FromRoute] int id)
        {
            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult UpdateTracking([FromRoute] int id)
        {
            return Ok();
        }

        [HttpPost]
        [Route("{trackingId}/participants/{userId}/invite")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult InviteUserToParticipateInTracking([FromRoute] int trackingId, [FromRoute] int userId)
        {
            return Ok();
        }

        [HttpPost]
        [Route("{trackingId}/participants/{userId}/exclude")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult ExcludeUserFromTrackingParticipants([FromRoute] int trackingId, [FromRoute] int userId)
        {
            return Ok();
        }
    }
}
