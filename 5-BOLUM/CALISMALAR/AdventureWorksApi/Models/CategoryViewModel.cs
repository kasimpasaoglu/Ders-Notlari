// Purpose: Model for category and subcategory.
/// <summary>
/// Model for category.
/// </summary>
public class CategoryViewModel
{
    /// <summary>
    /// Category Id.
    /// </summary>
    public int ProductCategoryId { get; set; }

    /// <summary>
    /// Category name.
    /// </summary>
    public string Name { get; set; } = null!;
}


/// <summary>
/// Model for subcategory.
/// </summary>
public class SubCategoryViewModel
{
    /// <summary>
    /// Subcategory Id.
    /// </summary>
    public int ProductSubcategoryId { get; set; }

    /// <summary>
    /// Subcategory name.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Category Id.
    /// </summary>
    public int ProductCategoryId { get; set; }
}