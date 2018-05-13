using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Lannister.Controllers
{
    [Produces("application/json")]
    [Route("signin")]
    public class AuthorizationController : Controller
    {
        public AuthorizationController()
        {

        }

        /// <summary>
        /// Authorize user with credentials: email and password are required
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult Login()
        {
            return Ok();
        }

        /// <summary>
        /// Authorize user with facebook account
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("facebook")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult LoginViaFacebook()
        {
            return Ok();
        }

        /// <summary>
        /// Authorize user with google account
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("google")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult LoginViaGoogle()
        {
            return Ok();
        }
    }
}
