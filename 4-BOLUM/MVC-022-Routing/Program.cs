var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

// Root ("/") adresine gidildiğinde Wissen/AnaSayfa'ya yönlendir
app.MapGet("/", () => Results.Redirect("/Wissen/AnaSayfa"));

// Attribute routing'i aktif et
app.MapControllers();

app.Run();
