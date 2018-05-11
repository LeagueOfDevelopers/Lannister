using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Lannister.Controllers
{
    /// <summary>
    /// Contains search engine which select users available to be invited
    /// </summary>
    [Produces("application/json")]
    [Route("tracking/{trackingId}/users")]
    public class UsersController : Controller
    {
        public UsersController()
        {

        }

        //accepts query string with filter attributes
        [HttpGet]
        [Route("search")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult SearchUsers([FromRoute] int trackingId)
        {
            return Ok();
        }
    }
}
