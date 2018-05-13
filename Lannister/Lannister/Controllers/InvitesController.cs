using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Lannister.Controllers
{
    [Produces("application/json")]
    [Route("users/{userId}/invites")]
    public class InvitesController : Controller
    {
        public InvitesController()
        {

        }

        /// <summary>
        /// Get all user invites
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult GetInvites([FromRoute] int userId)
        {
            return Ok();
        }

        /// <summary>
        /// Accept selected by user invite
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("{id}/accept")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult AcceptInvite([FromRoute] int userId, [FromRoute] int id)
        {
            return Ok();
        }

        /// <summary>
        /// Deny selected by user invite
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("{id}/deny")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult DenyInvite([FromRoute] int userId, [FromRoute] int id)
        {
            return Ok();
        }
    }
}
