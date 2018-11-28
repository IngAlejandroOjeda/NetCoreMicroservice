// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceNameContext.cs" company="Axity">
//   Axity
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Axity.Project.ServiceName.Persistence
{
    using Axity.Project.ServiceName.Persistence.Entities;
    using Microsoft.EntityFrameworkCore;

    public class ServiceNameContext : DbContext, IContext
    {
        public ServiceNameContext() { }
        
        public ServiceNameContext(DbContextOptions<ServiceNameContext> options)
        : base(options)
        { }

        public virtual DbSet<User> Users { get; set; }
    }
}
