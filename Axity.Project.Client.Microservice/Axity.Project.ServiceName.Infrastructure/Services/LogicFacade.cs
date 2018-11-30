// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LogicFacade.cs" company="Axity">
//   Axity
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Axity.Project.ServiceName.Infrastructure.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AutoMapper;
    using Axity.Project.ServiceName.Infrastructure.DTO;
    using Axity.Project.ServiceName.Persistence.Entities;

    public class LogicFacade : ILogicFacade
    {   
        private readonly IUsersService _usersService;
        private IMapper _mapper;

        public LogicFacade(
            IUsersService usersService,
            IMapper mapper)
        {
            _usersService = usersService ?? throw new ArgumentNullException(nameof(usersService));
            _mapper = mapper;
        }

        public async Task<IEnumerable<User>> GetListUsersActive()
        {
            return await _usersService.GetAllUsersAsync();
        }

        public async Task<User> GetListUserActive(int id)
        {
            return await _usersService.GetUserAsync(id);
        }

        public async Task InsertUser(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            await _usersService.InsertUser(user);
        }
    }
}
