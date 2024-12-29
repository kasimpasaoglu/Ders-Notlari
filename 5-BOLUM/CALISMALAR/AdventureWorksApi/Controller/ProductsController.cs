using Microsoft.AspNetCore.Mvc;

/// <summary>
/// ProductsController, ürünlerle ilgili API işlemlerini sağlar.
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
    /// Tüm ürünleri getirir. (isteğe bağlı limit ile)
    /// </summary>
    /// <param name="count">Dönen ürün sayısı</param>
    /// <returns>Ürün listesi</returns>
    [HttpGet]
    public IActionResult Get([FromQuery] int count = 20)
    {
        var result = _repo.GetAllProducts(count);

        if (result == null)
        {
            return NotFound("No products found");
        }
        return Ok(result);
    }

    /// <summary>
    /// Belirtilen ID'ye sahip ürünü döndürür.
    /// </summary>
    /// <param name="id">Ürün ID.</param>
    /// <returns>Ürün bilgileri.</returns>
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