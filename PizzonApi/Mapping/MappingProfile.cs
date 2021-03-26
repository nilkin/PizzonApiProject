using AutoMapper;
using Data.Entities;
using PizzonApi.Resources.HomePage;

namespace PizzonApi.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Banner, BannerResource>()
                .ForMember(d => d.PhotoUrl, opt => opt.MapFrom(src => src.PhotoUrl));
            CreateMap<Product, ProductPromoResource>()
                .ForMember(p => p.PhotoUrl, opt => opt.MapFrom(src => src.PhotoUrl));
            CreateMap<Product, ProductCategoryResource>()
                .ForMember(p => p.PhotoUrl, opt => opt.MapFrom(src => src.PhotoUrl))
                .ForMember(d => d.Price, opt => opt.MapFrom(src => src.Stock.Price));
            CreateMap<Associate, AssociateResource>()
                .ForMember(p => p.PhotoUrl, opt => opt.MapFrom(src => src.PhotoUrl)); 
            CreateMap<Blog, BlogResource>()
                .ForMember(p => p.PhotoUrl, opt => opt.MapFrom(src => src.PhotoUrl));
            CreateMap<AboutUs, AboutUsResource>()
                .ForMember(p => p.PhotoUrl, opt => opt.MapFrom(src => src.PhotoUrl));
            CreateMap<Reservation, ReservationResource>();
            CreateMap<ReservationResource, Reservation>();
        }
    }
}
