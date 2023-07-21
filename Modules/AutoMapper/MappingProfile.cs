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
            CreateMap<Feature, FeatureModel>();
            CreateMap<FeatureModel, Feature>();
            CreateMap<Transmission, TransmissioModel>();
            CreateMap<TransmissioModel, Transmission>();
            CreateMap<BodyType, BodyTypeModel>();
            CreateMap<BodyTypeModel, BodyType>();
            // Add more mappings as needed for other entity-response model pairs
        }
    }
}
