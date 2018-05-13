using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Lannister.Controllers
{
    /// <summary>
    /// Contains only the actions available to participants
    /// </summary>
    [Produces("application/json")]
    [Route("trackings")]
    public class TrackingParticipantActionsController : Controller
    {
        public TrackingParticipantActionsController()
        {

        }

        /// <summary>
        /// Block tracking to not get notifications from it
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("{id}/block")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult BlockTracking([FromRoute] int id)
        {
            return Ok();
        }

        /// <summary>
        /// Unblock tracking to get notifications from it
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("{id}/unblock")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult UnblockTracking([FromRoute] int id)
        {
            return Ok();
        }
    }
}
