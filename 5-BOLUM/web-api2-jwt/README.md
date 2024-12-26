# Authentication Islemleri

- Daha once SHA512 ile bir sifreleme ornegi yapmistik.
- SHA512 'de sifreleme tek yonludur. Yani ornegin bir kullanici sifre bilgisini SHA512 ile encrypt ettikten sonra onu geri acip, sifreyi goremeyiz.
- Ancak JWT iki yonlu calisir. Veriye tekrar ulasabiliriz.
- Bu projede JWT kullanarak bir authentication yapacagiz
- [JWT Bearer](https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.JwtBearer) nuget paketini indiriyoruz.

- `appsettings.json` dosyasina gerekli konfigrasyonu giriyoruz (JwtSettings kismi)

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "JwtSettings": {
    "Key": "%n'[VN_Tm?GdmA^%n'[VN_Tm?GdmA^%n'[VN_Tm?GdmA^",
    "Issuer": "WissenIssuer",
    "Audience": "WissenAudience"
  }
}
```

- `Program.cs` dosyasinda Jwt Bearer icin configrasyonu yaziyoruz

```C#
var JwtSettings = builder.Configuration.GetSection("JwtSettings");
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(option =>
{
    option.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = JwtSettings["Issuer"],
        ValidAudience = JwtSettings["Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtSettings["Key"]))

    };
});
```

- Hemen altinda builder servise Authorizationu ekliyoruz

```C#
builder.Services.AddAuthorization();
```

- Yine `Program.cs` icinde `app.Run()` satirindan once middlevare'i calistimamiz gerekiyor

```C#
app.UseAuthentication(); // Authentication middleware calistir
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization(); // Authorization middleware calistir
app.MapControllers();

app.Run();
```

- :warning: `app.UseAuthorization()` middleware'i `UseRoutin()` ten sonra calistirilmadilir!!!

- Artik `AuthController.cs` controllerina gidip bit `HttpPost` Actionunda, girisin dogru olup olmadigini kontrol ederiz. UserName bilgisi bizim sistemimizdeki username ile uyusmuyorsa bir kosul icinde Unauthorized donebiliriz

```C#
if (model.UserName != USERNAME || model.Password != PASSWORD)
{
    return Unauthorized("Gecersiz Kullanici adi ve sifre");
}
```

- Eger uyusuyorsa kullaniciya yanit olarak bir token donmemiz gerekiyor. Bunu da asagidaki ornekteki gibi yapariz

```C#
var tokenHandler = new JwtSecurityTokenHandler();
var key = Encoding.ASCII.GetBytes(Configuration["JwtSettings:Key"]);
var tokenDescriptor = new SecurityTokenDescriptor
{
    Subject = new System.Security.Claims.ClaimsIdentity(new[]{
      // claims bir token icinde bilgileri tasimak icin kullanilan yontemdir.
         new Claim(ClaimTypes.Name, model.UserName),
         new Claim(ClaimTypes.Role, "Admin")
    }),
    Expires = DateTime.UtcNow.AddHours(1),
    Issuer = Configuration["JwtSettings:Issuer"],
    Audience = Configuration["JwtSettings:Audience"],
    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
};
var token = tokenHandler.CreateToken(tokenDescriptor);
var tokenString = tokenHandler.WriteToken(token);
return Ok(tokenString);
```

- Artik kullanilmasi icin Authorization gereken Actionlarin ve ya Controller'larin basina `[Authorize]` attribute'u ekleyerek, kullanmak isteyen clientin tokeninin olup olmadigina bakabiliriz.

```C#
[Authorize]
public class SecurityController:ControllerBase
{
    public IActionResult Get()
    {
        return Ok("token tarafından korunan veriye erişildi");
    }
}
```

- Istemcinin bu controllerdaki metodlardan yanit almasi icin sorgusu ile birlikte login olurken bizden aldigi token bilgisini Header kisminda Authorization key'i ile birlikte gondermelidir.
