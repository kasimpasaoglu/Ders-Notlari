using HealthChecks.UI.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();

//web apinin bagli oldugu tum bagimliliklarin saglik durumunu kontrol edebiliriz.

builder.Services.AddHealthChecks()
    .AddSqlServer(
        connectionString: "Server=db11596.public.databaseasp.net; Database=db11596; User Id=db11596; Password=i#5G!Tc2p6J+; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True;",
        healthQuery: "SELECT 1;",
        name: "Sql Server",
        tags: new[] { "db", "sql" })
    .AddRedis(
        redisConnectionString: "redis-11810.c300.eu-central-1-1.ec2.redns.redis-cloud.com:11810,password=YvGRpGrL8NjVKU8i085NR3UwsC2o9wSo,abortConnect=false",
        name: "Redis")
    .AddCheck<ApiHealthCheck>("Rick and Morty Api Check");



// healty check ekranini ui olarak gostermek icin
builder.Services.AddHealthChecksUI(setup =>
{

    setup.AddHealthCheckEndpoint("Basic Health Check", "/healthy");
}).AddInMemoryStorage();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.MapControllers();


// app.MapHealthChecks("/healthy");


// app.MapHealthChecks("/healthy", new Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions
// {
//     ResponseWriter = async (context, report) =>
//     {
//         var json = System.Text.Json.JsonSerializer.Serialize(new
//         {
//             checks = report.Entries.Select(entry => new
//             {
//                 name = entry.Key,
//                 status = entry.Value.Status.ToString(),
//                 exception = entry.Value.Exception?.Message,
//             })
//         });

//         await context.Response.WriteAsync(json);
//     }
// });

/////
app.MapHealthChecks("/healthy", new Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions
{
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});
////

app.UseHealthChecksUI(opt =>
{
    opt.UIPath = "/healthyUI";
});



app.Run();

