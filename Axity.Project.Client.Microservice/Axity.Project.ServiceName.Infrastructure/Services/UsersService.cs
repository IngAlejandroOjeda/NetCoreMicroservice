// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UsersService.cs" company="Axity">
//   Axity
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Axity.Project.ServiceName.Infrastructure.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Axity.Project.ServiceName.Infrastructure.Repositories;
    using Axity.Project.ServiceName.Persistence.Entities;

    public class UsersService : IUsersService
    {   
        private readonly IUsersRepository _locationsRepository;

        public UsersService(IUsersRepository locationsRepository)
        {
            _locationsRepository = locationsRepository ?? throw new ArgumentNullException(nameof(locationsRepository));
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _locationsRepository.GetAllUsersAsync();
        }

        public async Task<User> GetUserAsync(int userId)
        {
            return await _locationsRepository.GetUserAsync(userId);
        }

        public async Task InsertUser(User user)
        {
            var temp = await Task.FromResult(true);
        }
    }
}
