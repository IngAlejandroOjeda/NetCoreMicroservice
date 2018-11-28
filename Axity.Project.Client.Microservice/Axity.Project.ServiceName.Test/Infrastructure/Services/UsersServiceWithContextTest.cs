// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UsersServiceWithContextTest.cs" company="Axity">
//   Axity
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Axity.Project.ServiceName.Test.Infrastructure.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using Axity.Project.ServiceName.Infrastructure.Repositories;
    using Axity.Project.ServiceName.Infrastructure.Services;
    using Axity.Project.ServiceName.Persistence;
    using Axity.Project.ServiceName.Test.Common;
    using Moq;
    using Xunit;

    public class UsersServiceWithContextTest
    {
        private IUsersService userServices;
        private IUsersRepository userRepository;
        private readonly Mock<ServiceNameContext> mock;

        public UsersServiceWithContextTest()
        {
            mock = new Mock<ServiceNameContext>();
            mock.Setup(c => c.Users).ReturnsDbSet(GetAllUsers());
        }

        [Fact(DisplayName = "GetAllUsers")]
        public async void ValidateGetAllUsers()
        {
            userRepository = new UsersRepository(mock.Object);
            userServices = new UsersService(userRepository);

            var result = await userServices.GetAllUsersAsync();

            Assert.True(result != null);
            Assert.True(result.Count() > 0);
        }

        [Fact(DisplayName = "SpecificUsers")]
        public async void ValidateSpecificUsers()
        {
            userRepository = new UsersRepository(mock.Object);
            userServices = new UsersService(userRepository);

            var result = await userServices.GetUserAsync(2);

            Assert.True(result != null);
            Assert.True(result.FirstName == "Jorge");
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
