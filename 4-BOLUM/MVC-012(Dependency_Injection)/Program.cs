var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// app tanimindan once yazilmali.
// sinifinin bir interface'i varsa (buyuk projelerde her zaman olmali)
// AddScoped generic metoduna, interface'i ve classi veriyoruz
// artik action icerisinde bu sinifi daha kolay kullanabiliriz.
builder.Services.AddScoped<IHelper, Helper>();

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
