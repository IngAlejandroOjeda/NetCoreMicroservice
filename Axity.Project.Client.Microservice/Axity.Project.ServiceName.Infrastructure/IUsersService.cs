// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUsersService.cs" company="Axity">
//   Axity
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Axity.Project.ServiceName.Infrastructure
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Axity.Project.ServiceName.Persistence.Entities;

    public interface IUsersService
    {
        Task<IEnumerable<User>> GetAllUsersAsync();

        Task<User> GetUserAsync(int userId);

        Task InsertUser(User user);
    }
}
