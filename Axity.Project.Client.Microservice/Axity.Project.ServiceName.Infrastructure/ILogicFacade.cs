// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILogicFacade.cs" company="Axity">
//   Axity
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Axity.Project.ServiceName.Infrastructure
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Axity.Project.ServiceName.Infrastructure.DTO;
    using Axity.Project.ServiceName.Persistence.Entities;

    public interface ILogicFacade
    {
        Task<IEnumerable<User>> GetListUsersActive();

        Task<User> GetListUserActive(int id);

        Task InsertUser(UserDto user);
    }
}