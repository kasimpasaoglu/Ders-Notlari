public interface IRepo
{
    public ProductViewModel GetProductById(int id);
    public List<ProductViewModel> GetProductsByFilters(
        int productRequested,
        int page,
        string? selectedSort = null,
        int? categoryId = null,
        int? subcategoryId = null,
        decimal? minPrice = null,
        decimal? maxPrice = null,
        List<string>? selectedColors = null
    );
    public List<CategoryViewModel> GetCategories();
    public List<SubCategoryViewModel> GetSubCategories(int categoryId);
    public List<string> GetColors();
}