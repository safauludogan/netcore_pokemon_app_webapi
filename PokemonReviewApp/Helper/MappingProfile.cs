using AutoMapper;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Pokemon, PokemonDto>().ReverseMap();
            CreateMap<Pokemon, CategoryDto>();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Owner, OwnerDto>().ReverseMap();
            CreateMap<Review, ReviewDto>().ReverseMap();
            CreateMap<Reviewer, ReviewerDto>().ReverseMap();
            CreateMap<Reviewer, ReviewDto>();
            CreateMap<CategoryDto, Category>();
        }
    }
}
