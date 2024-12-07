using Newtonsoft.Json;

public class WebApiService : IWebApiService
{
    public IWebApiRepository _webApiRepo;
    public WebApiService(IWebApiRepository webApiRepo)
    {
        _webApiRepo = webApiRepo;
    }

    public RickAndMortyDMO GetAll()
    {
        string jsonString = _webApiRepo.GetAll(); // string tipinde json verimiz burda
        RickAndMortyDMO resultData = JsonConvert.DeserializeObject<RickAndMortyDMO>(jsonString); // newtonsoft paketi ile bu veriyi RickAndMoryDMO tipine donustuduk.
        return resultData; // ve bunu geri dondurduk.
    }
}
public interface IWebApiService
{
    public RickAndMortyDMO GetAll();
}