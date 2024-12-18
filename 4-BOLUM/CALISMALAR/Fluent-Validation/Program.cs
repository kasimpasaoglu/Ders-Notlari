using FluentValidation;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddFluentValidationAutoValidation(); // otomatik model dogrulama - ModelState hatalari FluentValidation kurallarina gore otomatik olarak doldurur
builder.Services.AddFluentValidationClientsideAdapters(); // istemci tarafi dogrulama - Istemci tarafinda (JS ile) dogrulama mesajlarinin calismasini saglar
builder.Services.AddValidatorsFromAssemblyContaining<Program>(); // validator siniflarini kaynetme - Validatotr siniflarini otomatik olarak tarayip kaydeder, Program sinifinin bulundugu assembly'den validationlari bulur

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
