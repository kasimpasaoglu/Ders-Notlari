
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private const string USERNAME = "root";
    private const string PASSWORD = "1010";
    public IConfiguration Configuration;
    public AuthController(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    [HttpPost]
    public IActionResult Login(AuthModel model)
    {
        if (model.UserName != USERNAME || model.Password != PASSWORD)
        {
            return Unauthorized("Gecersiz Kullanici adi ve sifre");
        }
        // Burda dogru oldugunu kabul ediyoruz 
        // Gelen kullanici adi ve sifreye gore JWT token uretelim.
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(Configuration["JwtSettings:Key"]);

        var tokenDescriptor = new SecurityTokenDescriptor
        {

            Subject = new System.Security.Claims.ClaimsIdentity(new[]{

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
    }
}