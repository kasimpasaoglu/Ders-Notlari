using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class HeaderController : ControllerBase
{

    // Web Api'ler iki kisimdan olusur. 
    // 1. Body Kismi -> Gonderilen veriler bulunur. Mesaj govdesidir
    // 2. Header Kismi -> Ust bilgi olarak gonderilecek verileri tasir.
    // Ust bilgiler neler olabilir?
    // Api 'de eger Authentication var ise, authentication bilgilerini tasir
    // Istek yapilan kaynagin IP numarasini tasir
    // Istek yapilan kaynagin browser bilgilerini tasir
    // Yapilan istegin tipini tasir 
    [HttpPost]
    public IActionResult Post()
    {
        // Yapilan istekte header kismina ulasmak icin
        string authorizateion = HttpContext.Request.Headers["Authorization"].ToString();
        string userAgent = HttpContext.Request.Headers["User-Agent"].ToString();
        return Ok();
    }

    [HttpGet]
    public IActionResult Get()
    {
        string authorization = HttpContext.Request.Headers["Authorization"].ToString();

        var products = new[]
        {
            new { Id =1, Name = "Kalem"},

            new { Id =2, Name = "Kağıt"},

            new { Id =3, Name = "Silgi"},

            new { Id =4, Name = "Masa"},

            new { Id =5, Name = "Bilgisayar"},

            new { Id =6, Name = "Mouse"},
        };
        return Ok(products);
    }
}