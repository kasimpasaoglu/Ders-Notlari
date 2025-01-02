using generic_repository_04.DMO;
using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase
{
    private IBookService _bookService;
    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var result = _bookService.Get();
        if (result.Count > 0)
        {
            return Ok(result);
        }
        else
        {
            return NoContent();
        }
    }

    [HttpPost]
    public IActionResult Find(KitapVM model)
    {
        var result = _bookService.Find(model).Result.ToList();
        return Ok(result);
    }
}