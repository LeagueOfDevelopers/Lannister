using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Lannister.Controllers
{
    /// <summary>
    /// Contains common actions available to participants and creators
    /// </summary>
    [Produces("application/json")]
    [Route("trackings")]
    public class TrackingCommonActionsController : Controller
    {
        public TrackingCommonActionsController()
        {

        }

        [HttpGet]
        [Route("{id}")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult GetTracking([FromRoute] int id)
        {
            return Ok();
        }

        //accepts optional query string parameters
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
