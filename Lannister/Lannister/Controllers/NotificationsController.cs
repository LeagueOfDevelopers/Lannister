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

        /// <summary>
        /// Get all user notifications
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult GetNotifications([FromRoute] int userId)
        {
            return Ok();
        }

        /// <summary>
        /// Get user current notification settings
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("settings")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult GetNotificationSettings([FromRoute] int userId)
        {
            return Ok();
        }

        /// <summary>
        /// Change user notification settings
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("settings")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult UpdateNotificationSettings([FromRoute] int userId)
        {
            return Ok();
        }
    }
}
