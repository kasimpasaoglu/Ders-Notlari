using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("api/[controller]")]
public class AuthorController : ControllerBase
{
    private IAuthorService _authorService;
    public AuthorController(IAuthorService authorService)
    {
        _authorService = authorService;
    }
    public IActionResult Get()
    {
        var result = _authorService.Get();
        if (result.Count != 0)
        {
            return Ok(result);
        }
        else
        {
            return NotFound();
        }
    }
}