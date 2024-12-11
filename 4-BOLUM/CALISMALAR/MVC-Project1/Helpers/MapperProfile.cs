using DMO;
using DTO;
using VM;
using AutoMapper;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        // Student  Maplemesi
        CreateMap<DMO.Student, DTO.Student>().ReverseMap();
        CreateMap<DTO.Student, VM.Student>().ReverseMap();



        // Login maplemesi
        CreateMap<DMO.Login, DTO.Login>().ReverseMap();

        // DTO <-> VM arasinda login modelde sifre encrypt edilmeli.
        CreateMap<DTO.Login, VM.Login>();
        CreateMap<VM.Login, DTO.Login>()
        .ForMember(dest => dest.Password, opt => opt.MapFrom(src => ShaHelper.ToSha512(src.Password)));


    }
}
