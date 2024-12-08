using DMO;
using DTO;
using VM;
using AutoMapper;

public class RickAndMortyMappingProfile : Profile
{
    public RickAndMortyMappingProfile()
    {
        CreateMap<RickAndMortyDMO, RickAndMortyDTO>().ReverseMap();
        CreateMap<RickAndMortyDTO, RickAndMortyVM>().ReverseMap();

        CreateMap<DMO.Info, DTO.Info>().ReverseMap();
        CreateMap<DTO.Info, VM.Info>().ReverseMap();

        CreateMap<DMO.Detail, DTO.Detail>().ReverseMap();
        CreateMap<DTO.Detail, VM.Detail>().ReverseMap();

        CreateMap<DMO.Location, DTO.Location>().ReverseMap();
        CreateMap<DTO.Location, VM.Location>().ReverseMap();
    }
}
