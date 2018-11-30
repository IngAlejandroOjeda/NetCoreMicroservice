// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AutoMapperProfile.cs" company="Axity">
//   Axity
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Axity.Project.ServiceName.Infrastructure.Helpers
{
    using AutoMapper;
    using Axity.Project.ServiceName.Infrastructure.DTO;
    using Axity.Project.ServiceName.Persistence.Entities;

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}