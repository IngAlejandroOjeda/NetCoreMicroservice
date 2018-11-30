// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UsersServiceTest.cs" company="Axity">
//   Axity
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Axity.Project.ServiceName.Test.Infrastructure.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Axity.Project.ServiceName.Infrastructure;
    using Axity.Project.ServiceName.Infrastructure.Repositories;
    using Axity.Project.ServiceName.Infrastructure.Services;
    using Moq;
    using Xunit;

    public class UsersServiceTest
    {
        private readonly IUsersService userServices;
        private readonly Mock<IUsersRepository> repositoryUsers;

        public UsersServiceTest()
        {
            repositoryUsers = new Mock<IUsersRepository>();
            userServices = new UsersService(repositoryUsers.Object);
        }

        [Fact]
        public async void ValidateGetAllUsers()
        {
            repositoryUsers.Setup(c => c.GetAllUsersAsync()).Returns(Task.FromResult(GetAllUsers()));

            var result = await userServices.GetAllUsersAsync();
            Assert.True(result != null);
            Assert.True(result.Count() > 0);
        }

        public IEnumerable<Persistence.Entities.User> GetAllUsers()
        {
            return new List<Persistence.Entities.User>()
            {
                new Persistence.Entities.User { Id = 1, FirstName = "Alejandro", LastName = "Ojeda", Email = "alejandro.ojeda@axity.com" },
                new Persistence.Entities.User { Id = 2, FirstName = "Jorge", LastName = "Morales", Email = "jorge.morales@axity.com" },
                new Persistence.Entities.User { Id = 3, FirstName = "Arturo", LastName = "Miranda", Email = "arturo.miranda@axity.com" },
                new Persistence.Entities.User { Id = 4, FirstName = "Benjamin", LastName = "Galindo", Email = "benjamin.galindo@axity.com" }
            };
        }
    }
}
