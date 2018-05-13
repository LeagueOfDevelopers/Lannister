using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Lannister.Controllers
{
    [Produces("application/json")]
    [Route("signup")]
    public class RegistrationController : Controller
    {
        public RegistrationController()
        {

        }
        
        /// <summary>
        /// Authenticate user if email and password are specified
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult Register()
        {
            return Ok();
        }

        /// <summary>
        /// Authenticate user if selected registration type is via Facebook
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("facebook")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult RegisterViaFacebook()
        {
            return Ok();
        }

        /// <summary>
        /// Authenticate user if selected registration type is via Google
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("google")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult RegisterViaGoogle()
        {
            return Ok();
        }
    }
}
