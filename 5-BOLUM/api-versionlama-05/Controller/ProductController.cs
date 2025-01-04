using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/product")]
public class ProductController : ControllerBase
{

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Product Api v1");
    }
}