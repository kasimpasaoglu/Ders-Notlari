using Microsoft.Extensions.Diagnostics.HealthChecks;
using RestSharp;

public class ApiHealthCheck : IHealthCheck
{
    private readonly HttpClient _httpClient;
    public ApiHealthCheck(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        // interfaceden gelen metodun icini dolduralim
        RestSharp.RestClient cli = new RestSharp.RestClient("https://rickandmortyapi.com/api/character");
        RestSharp.RestRequest req = new RestSharp.RestRequest();
        req.Method = RestSharp.Method.Get;
        var response = cli.Execute(req);

        if (!string.IsNullOrEmpty(response.Content))
        {
            return HealthCheckResult.Healthy("Healthy");
        }
        else
        {
            return HealthCheckResult.Unhealthy("Un-Healthy");
        }
    }
}