public class ProductFilterRequest
{
    public int ProductRequested { get; set; }
    public int Page { get; set; }
    public string? SelectedSort { get; set; }
    public int? CategoryId { get; set; }
    public int? SubcategoryId { get; set; }
    public decimal? MinPrice { get; set; }
    public decimal? MaxPrice { get; set; }
    public List<string>? SelectedColors { get; set; }
}
