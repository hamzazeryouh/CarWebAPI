using AutoMapper;
using CarWebAPI.Entities.Domain;
using CarWebAPI.Entities.Domain.Parametre;
using CarWebAPI.Modules.Parametre;

namespace CarWebAPI.Modules
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Login, User>();
            CreateMap<UserModel, User>();
            CreateMap<User, UserModel>();
            CreateMap<Brand, BrandModel>();
            CreateMap<BrandModel, Brand>();

            CreateMap<Model,ModelView>();
            CreateMap<ModelView, Model>();
            // Add more mappings as needed for other entity-response model pairs
        }
    }
}
