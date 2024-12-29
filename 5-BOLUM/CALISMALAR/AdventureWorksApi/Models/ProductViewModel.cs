
public partial class ProductViewModel
{

    public int ProductId { get; set; }
    public string Name { get; set; } = null!;
    public string ProductNumber { get; set; } = null!;
    public string? Color { get; set; }
    public decimal StandardCost { get; set; }
    public decimal ListPrice { get; set; }
    public string? Size { get; set; }
    public string? SizeUnitMeasureCode { get; set; }
    public decimal? Weight { get; set; }
    public string? WeightUnitMeasureCode { get; set; }
    public string? Style { get; set; }
    public int? ProductSubcategoryId { get; set; }
    public int? ProductModelId { get; set; }
    public int? ProductCategoryId { get; set; }
    public string? ProductCategoryName { get; set; }
    public string? ProductSubcategoryName { get; set; }
    public byte[]? ProductPhoto { get; set; }
    public string? ProductDescription { get; set; }

}
