using Microsoft.AspNetCore.Mvc;

/// <summary>
/// Get single or list of products
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private IRepo _repo;

    public ProductsController(IRepo repo)
    {
        _repo = repo;
    }


    /// <summary>
    /// Get products list by filters
    /// </summary>
    /// <param name="productFilter"></param>
    /// <returns>Product list filtered by params</returns>
    [HttpPost]
    public IActionResult Get([FromBody] ProductFilterRequest productFilter)
    {
        var result = _repo.GetProductsByFilters(
            productFilter.ProductRequested,
            productFilter.Page,
            productFilter.SelectedSort,
            productFilter.CategoryId,
            productFilter.SubcategoryId,
            productFilter.MinPrice,
            productFilter.MaxPrice,
            productFilter.SelectedColors
        );

        if (result == null || result.Count == 0)
        {
            return NotFound("No products found");
        }
        return Ok(result);
    }

    /// <summary>
    /// Get single product by id
    /// </summary>
    /// <param name="id">Product ID</param>
    /// <returns>Detailed product information</returns>
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var result = _repo.GetProductById(id);

        if (result == null)
        {
            return NotFound("Product not found");
        }
        return Ok(result);
    }
}