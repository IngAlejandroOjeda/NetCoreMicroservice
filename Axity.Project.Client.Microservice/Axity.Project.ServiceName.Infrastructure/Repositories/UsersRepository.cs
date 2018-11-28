// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UsersRepository.cs" company="Axity">
//   Axity
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Axity.Project.ServiceName.Infrastructure.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Axity.Project.ServiceName.Persistence;
    using Axity.Project.ServiceName.Persistence.Entities;
    using Microsoft.EntityFrameworkCore;

    public class UsersRepository : IUsersRepository
    {
        private readonly ServiceNameContext _context;

        public UsersRepository(ServiceNameContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUserAsync(int userId)
        {
            return await _context.Users.Where(c=> c.Id == userId).FirstOrDefaultAsync();
        }
    }
}
