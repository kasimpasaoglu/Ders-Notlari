using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IWebApiRepository, WebApiRepository>();
builder.Services.AddScoped<IWebApiService, WebApiService>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var serviceProvider = builder.Services.BuildServiceProvider();
var mapper = serviceProvider.GetRequiredService<IMapper>();

try
{
    mapper.ConfigurationProvider.AssertConfigurationIsValid();
    Console.WriteLine("Mapping configuration is valid!");
}
catch (Exception ex)
{
    Console.WriteLine($"Mapping configuration error: {ex.Message}");
}



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
