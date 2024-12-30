using Microsoft.AspNetCore.Mvc;
/// <summary>
/// Filter controller
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class FilterController : ControllerBase
{
    private IRepo _repo;

    public FilterController(IRepo repo)
    {
        _repo = repo;
    }
    /// <summary>
    /// Get all categories
    /// </summary>
    /// <returns>Categories list</returns>
    [HttpGet]
    [Route("categories")]
    public IActionResult Get()
    {
        var result = _repo.GetCategories();

        if (result == null || result.Count == 0)
        {
            return NotFound("No categories found");
        }
        return Ok(result);
    }

    /// <summary>
    /// Get subcategories by category id
    /// </summary>
    /// <param name="id">Category Id</param>
    /// <returns>SubCategories list by given Category Id</returns>
    [HttpGet]
    [Route("categories/{id}")]
    public IActionResult Get(int id)
    {
        var result = _repo.GetSubCategories(id);

        if (result == null || result.Count == 0)
        {
            return NotFound("No subcategories found");
        }
        return Ok(result);
    }

    /// <summary>
    /// Get all colors
    /// </summary>
    /// <returns>All available colors list</returns>
    [HttpGet]
    [Route("colors")]
    public IActionResult GetColors()
    {
        var result = _repo.GetColors();

        if (result == null || result.Count == 0)
        {
            return NotFound("No colors found");
        }
        return Ok(result);
    }
}