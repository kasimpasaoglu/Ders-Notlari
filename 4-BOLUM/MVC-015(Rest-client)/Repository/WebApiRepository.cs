using DMO;
using Newtonsoft.Json;
using RestSharp;

public class WebApiRepository : IWebApiRepository
{
    public RickAndMortyDMO GetAll()
    {
        var options = new RestClientOptions("https://rickandmortyapi.com/api/");
        var client = new RestClient(options);
        var request = new RestRequest("character");
        request.Method = Method.Get;
        var result = client.Get(request);
        string jsonData = result.Content; // string tipinde json verimiz burda
        RickAndMortyDMO resultData = JsonConvert.DeserializeObject<RickAndMortyDMO>(jsonData); // newtonsoft paketi ile bu veriyi RickAndMoryDMO tipine donustuduk.
        return resultData;
    }
}

public interface IWebApiRepository
{
    public RickAndMortyDMO GetAll();
}