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

        [HttpGet]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult GetInvites([FromRoute] int userId)
        {
            return Ok();
        }

        [HttpPost]
        [Route("{id}/accept")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult AcceptInvite([FromRoute] int userId, [FromRoute] int id)
        {
            return Ok();
        }

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
