﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Lannister.Controllers
{
    /// <summary>
    /// Contains only the actions available to tracking creator
    /// </summary>
    [Produces("application/json")]
    [Route("trackings")]
    public class TrackingCreatorActionsController : Controller
    {
        public TrackingCreatorActionsController()
        {

        }

        /// <summary>
        /// Create new tracking
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult CreateTracking()
        {
            return Ok();
        }

        /// <summary>
        /// Send tracking to archive
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("{id}/disable")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult DisableTracking([FromRoute] int id)
        {
            return Ok();
        }

        /// <summary>
        /// Change tracking fields
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult UpdateTracking([FromRoute] int id)
        {
            return Ok();
        }

        /// <summary>
        /// Send invitation to found user
        /// </summary>
        /// <param name="trackingId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("{trackingId}/participants/{userId}/invite")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult InviteUserToParticipateInTracking([FromRoute] int trackingId, [FromRoute] int userId)
        {
            return Ok();
        }

        /// <summary>
        /// Exclude specified user from tracking participants
        /// </summary>
        /// <param name="trackingId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
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
