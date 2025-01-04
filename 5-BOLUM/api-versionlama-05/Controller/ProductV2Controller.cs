using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
[ApiController]
[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/product")]
public class ProductV2Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Product Api v2");
    }
}