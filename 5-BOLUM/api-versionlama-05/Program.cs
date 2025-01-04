var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddApiVersioning(opt =>
{
    opt.ReportApiVersions = true;
    opt.AssumeDefaultVersionWhenUnspecified = true; // api surumu verilmezse default olani kullanir
    opt.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 2); // yukaridaki prop ile iliskili olarak default versionu belirle
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseApiVersioning();
app.MapControllers();

app.Run();


