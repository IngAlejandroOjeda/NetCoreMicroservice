// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UsersController.cs" company="Axity">
//   Axity
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Axity.Project.ServiceName.Api.Controllers
{
    using System;
    using System.Threading.Tasks;
    using Axity.Project.ServiceName.Infrastructure.Services;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService ?? throw new ArgumentNullException(nameof(usersService));
        }

        //GET api/v1/[controller]/
        [Route("")]
        [HttpGet]
        //[ProducesResponseType(typeof(List<Locations>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get()
        {
            var locations = await _usersService.GetAllUsersAsync();
            return Ok(locations);
        }

        //GET api/v1/[controller]/user/1
        [Route("{userId}")]
        [HttpGet]
        //[ProducesResponseType(typeof(UserLocation), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get(int userId)
        {
            var userLocation = await _usersService.GetUserAsync(userId);
            return Ok(userLocation);
        }
    }
}