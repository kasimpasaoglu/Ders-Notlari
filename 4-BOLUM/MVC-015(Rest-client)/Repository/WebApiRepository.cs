using RestSharp;

public class WebApiRepository : IWebApiRepository
{
    public string GetAll()
    {
        var options = new RestClientOptions("https://rickandmortyapi.com/api/");
        var client = new RestClient(options);
        var request = new RestRequest("character");
        request.Method = Method.Get;
        var result = client.Get(request);
        return result.Content;


    }
}

public interface IWebApiRepository
{
    public string GetAll();
}