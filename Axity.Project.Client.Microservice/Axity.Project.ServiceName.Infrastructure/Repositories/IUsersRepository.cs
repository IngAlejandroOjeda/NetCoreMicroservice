// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUsersRepository.cs" company="Axity">
//   Axity
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Axity.Project.ServiceName.Infrastructure.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Axity.Project.ServiceName.Persistence.Entities;

    public interface IUsersRepository
    {
        Task<IEnumerable<User>> GetAllUsersAsync();

        Task<User> GetUserAsync(int userId);
    }
}
