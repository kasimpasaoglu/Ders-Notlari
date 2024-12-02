var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// redis baglantisini ayarla
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = "redis-18747.c55.eu-central-1-1.ec2.redns.redis-cloud.com:18747,password=96l8zmiQaQuLAMGz6SbEs8ihYDUdqn5S"; // Redis baglanti urlsi
    options.InstanceName = "RedisInstance"; // isim ver
});

// session ayarlari
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(10);
});

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
app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
