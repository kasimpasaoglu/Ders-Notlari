using AutoMapper;
using DMO;
using DTO;

public class WebApiService : IWebApiService
{
    public IWebApiRepository _webApiRepo;
    public IMapper _mapper;
    public WebApiService(IWebApiRepository webApiRepo, IMapper mapper)
    {
        _webApiRepo = webApiRepo;
        _mapper = mapper;
    }

    public RickAndMortyDTO GetAll()
    {
        RickAndMortyDMO data = _webApiRepo.GetAll();
        var dtoData = _mapper.Map<RickAndMortyDTO>(data);
        return dtoData;
    }
}
public interface IWebApiService
{
    public RickAndMortyDTO GetAll();
}