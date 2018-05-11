using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Lannister.Controllers
{
    [Produces("application/json")]
    [Route("users/{userId}/notifications")]
    public class NotificationsController : Controller
    {
        public NotificationsController()
        {

        }

        [HttpGet]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult GetNotifications([FromRoute] int userId)
        {
            return Ok();
        }

        [HttpGet]
        [Route("settings")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult AcceptNotification([FromRoute] int userId)
        {
            return Ok();
        }

        [HttpPut]
        [Route("settings")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult DenyNotification([FromRoute] int userId)
        {
            return Ok();
        }
    }
}
