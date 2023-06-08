using AutoMapper;
using CarWebAPI.Entities.Domain;

namespace CarWebAPI.Modules
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Login, User>();
            CreateMap<UserModel, User>();
            CreateMap<User, UserModel>();
            // Add more mappings as needed for other entity-response model pairs
        }
    }
}
