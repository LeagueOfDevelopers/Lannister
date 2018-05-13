using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Lannister.Controllers
{
    [Produces("application/json")]
    [Route("users")]
    public class ProfileController : Controller
    {
        public ProfileController()
        {

        }

        /// <summary>
        /// Get user profile fields
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult GetUserProfile([FromRoute] int id)
        {
            return Ok();
        }

        /// <summary>
        /// Change user profile fields
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        [SwaggerResponse(200, Type = typeof(object))]
        [SwaggerResponse(400, Type = typeof(object))]
        [SwaggerResponse(500, Type = typeof(object))]
        public IActionResult UpdateUserProfile([FromRoute] int id)
        {
            return Ok();
        }
    }
}
