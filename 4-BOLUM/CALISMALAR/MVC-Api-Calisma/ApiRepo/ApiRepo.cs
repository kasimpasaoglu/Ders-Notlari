using Newtonsoft.Json;
using RestSharp;

public interface IApiRepo
{
    public string GetJsonString();
}
public class ApiRepo : IApiRepo
{
    public string GetJsonString()
    {
        var options = new RestClientOptions("http://wissenwebapi.runasp.net/api/");
        var client = new RestClient(options);
        var request = new RestRequest("Wissen");
        request.Method = Method.Get;


        var result = client.Get(request);
        return result.Content;


    }
}