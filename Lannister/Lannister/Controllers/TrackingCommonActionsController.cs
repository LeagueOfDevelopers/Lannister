using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Lannister.Controllers
{
    /// <summary>
    /// Contains common actions available to participants and creator
    /// </summary>
    [Produces("application/json")]
    [Route("trackings")]
    public class TrackingCommonActionsController : Controller
    {
        public TrackingCommonActionsController()
        {

        }

        /// <summary>
        /// Get selected tracking fields
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult GetTracking([FromRoute] int id)
        {
            return Ok();
        }

        /// <summary>
        /// Get all user trackings or user trackings matching specified filters
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult GetTrackingsSelection()
        {
            return Ok();
        }
    }
}
