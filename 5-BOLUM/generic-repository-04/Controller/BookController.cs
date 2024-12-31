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
}