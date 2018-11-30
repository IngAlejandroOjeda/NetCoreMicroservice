// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UsersController.cs" company="Axity">
//   Axity
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Axity.Project.ServiceName.Api.Controllers
{
    using System;
    using System.Threading.Tasks;
    using Axity.Project.ServiceName.Infrastructure;
    using Axity.Project.ServiceName.Infrastructure.DTO;
    using Axity.Project.ServiceName.Infrastructure.Services;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ILogicFacade _logicFacade;

        public UsersController(ILogicFacade logicFacade)
        {
            _logicFacade = logicFacade ?? throw new ArgumentNullException(nameof(logicFacade));
        }

        //GET api/v1/[controller]/
        [Route("")]
        [HttpGet]
        //[ProducesResponseType(typeof(List<Locations>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get()
        {
            var locations = await _logicFacade.GetListUsersActive();
            return Ok(locations);
        }

        //GET api/v1/[controller]/user/1
        [Route("{userId}")]
        [HttpGet]
        //[ProducesResponseType(typeof(UserLocation), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get(int userId)
        {
            var userLocation = await _logicFacade.GetListUserActive(userId);
            return Ok(userLocation);
        }

        [HttpPost]
        //[ProducesResponseType(typeof(UserDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Post([FromBody] UserDto user)
        {
            await _logicFacade.InsertUser(user);
            return Ok();
        }
    }
}