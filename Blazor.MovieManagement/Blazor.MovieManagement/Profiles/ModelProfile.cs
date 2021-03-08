using AutoMapper;
using Blazor.MovieManagement.Database.Models;
using Blazor.MovieManagement.ViewModel;

namespace Blazor.MovieManagement.Profiles
{
    public class ModelProfile : Profile
    {
        public ModelProfile()
        {
            CreateMap<Movie, MovieViewModel>()
                .ForMember(dest => dest.Release, opt => opt.MapFrom(src => src.ReleaseDate))
                .ForMember(dest => dest.ProductionCompany, opt => opt.MapFrom(src => src.ProductionCompany.Name));
        }
    }
}