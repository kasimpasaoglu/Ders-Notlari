using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/[controller]")]
public class WissenController : ControllerBase
{



    [HttpPut]
    public IActionResult Put()
    {
        return Ok(true);
    }


    [HttpPatch]
    public IActionResult Patch()
    {

        return Ok(true);
    }


    [HttpDelete]
    public IActionResult x()
    {

        return Ok(true);
    }

    [HttpHead]
    public IActionResult Head()
    {

        return Ok(true);
    }



    [HttpOptions]
    public IActionResult Options()
    {
        return Ok(true);
    }
    public IActionResult Get()
    {
        // geriye product döndürelim 
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