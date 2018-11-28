// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IContext.cs" company="Axity">
//   Axity
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Axity.Project.ServiceName.Persistence
{
    using System;
    using Axity.Project.ServiceName.Persistence.Entities;
    using Microsoft.EntityFrameworkCore;

    public interface IContext : IDisposable
    {
        DbSet<User> Users { get; set; }
    }
}
