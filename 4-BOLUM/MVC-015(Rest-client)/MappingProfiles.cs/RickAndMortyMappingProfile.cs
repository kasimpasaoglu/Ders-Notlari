using DMO;
using DTO;
using VM;
using AutoMapper;

public class RickAndMortyMappingProfile : Profile
{
    public RickAndMortyMappingProfile()
    {
        CreateMap<RickAndMortyDMO, RickAndMortyDTO>();
        CreateMap<RickAndMortyDTO, RickAndMortyVM>();
        CreateMap<RickAndMortyVM, RickAndMortyDTO>();
        CreateMap<RickAndMortyDTO, RickAndMortyDMO>();

        CreateMap<DMO.Info, DTO.Info>();
        CreateMap<DTO.Info, VM.Info>();
        CreateMap<VM.Info, DTO.Info>();
        CreateMap<DTO.Info, DMO.Info>();

        CreateMap<DMO.Detail, DTO.Detail>();
        CreateMap<DTO.Detail, VM.Detail>();
        CreateMap<VM.Detail, DTO.Detail>();
        CreateMap<DTO.Detail, DMO.Detail>();

        CreateMap<DMO.Location, DTO.Location>();
        CreateMap<DTO.Location, VM.Location>();
        CreateMap<VM.Location, DTO.Location>();
        CreateMap<DTO.Location, DMO.Location>();
    }
}
