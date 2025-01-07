using AdventureWorksApi.DataAccessLayer;
using Microsoft.EntityFrameworkCore;

public class Repo : IRepo
{
    private AdventureWorksContext _context;


    public Repo(AdventureWorksContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Get product by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Detailed Product Model</returns>
    public ProductViewModel GetProductById(int id)
    {
        return _context.Products
            .Include(p => p.ProductProductPhotos)
            .Include(p => p.ProductModel)
                .ThenInclude(pm => pm.ProductModelProductDescriptionCultures)
                .ThenInclude(pmpdc => pmpdc.ProductDescription)
            .Where(x => x.ProductId == id)
            .Select(s => new ProductViewModel
            {
                ProductId = s.ProductId,
                Name = s.Name,
                ProductNumber = s.ProductNumber,
                Color = s.Color,
                StandardCost = s.StandardCost,
                ListPrice = s.ListPrice,
                Size = s.Size,
                SizeUnitMeasureCode = s.SizeUnitMeasureCode,
                Weight = s.Weight,
                WeightUnitMeasureCode = s.WeightUnitMeasureCode,
                Style = s.Style,
                ProductSubcategoryId = s.ProductSubcategoryId,
                ProductModelId = s.ProductModelId,
                ProductCategoryId = s.ProductSubcategory.ProductCategoryId,
                ProductCategoryName = s.ProductSubcategory.ProductCategory.Name,
                ProductSubcategoryName = s.ProductSubcategory.Name,
                ProductPhoto = s.ProductProductPhotos.FirstOrDefault().ProductPhoto.LargePhoto,
                ProductDescription = s.ProductModel.ProductModelProductDescriptionCultures.FirstOrDefault().ProductDescription.Description
            }).FirstOrDefault();
    }


    /// <summary>
    /// Get products by filters
    /// </summary>
    /// <param name="productRequested"></param>
    /// <param name="page"></param>
    /// <param name="selectedSort"></param>
    /// <param name="categoryId"></param>
    /// <param name="subcategoryId"></param>
    /// <param name="minPrice"></param>
    /// <param name="maxPrice"></param>
    /// <param name="selectedColors"></param>
    /// <returns>Product list filtered by params</returns>
    public List<ProductViewModel> GetProductsByFilters
    (
        int productRequested,
        int page,
        string? selectedSort = null,
        int? categoryId = null,
        int? subcategoryId = null,
        decimal? minPrice = null,
        decimal? maxPrice = null,
        List<string>? selectedColors = null
    )
    {
        var query = _context.Products
            .Include(p => p.ProductProductPhotos)
            .Include(p => p.ProductModel)
                .ThenInclude(pm => pm.ProductModelProductDescriptionCultures)
                .ThenInclude(pmpdc => pmpdc.ProductDescription)
            .Include(p => p.ProductSubcategory)
                .ThenInclude(psc => psc.ProductCategory)
            .AsQueryable();

        #region Category and Subcategory
        if (categoryId != null)
        {
            query = query.Where(x => x.ProductSubcategory.ProductCategoryId == categoryId);

            if (subcategoryId != null)
            {
                query = query.Where(x => x.ProductSubcategoryId == subcategoryId);
            }
        }
        #endregion

        #region Price and Colors
        if (minPrice.HasValue && minPrice != null)
        {
            query = query.Where(x => x.StandardCost >= minPrice);
        }
        if (maxPrice.HasValue && minPrice > 0)
            query = query.Where(p => p.StandardCost <= maxPrice.Value);

        if (selectedColors != null && selectedColors.Any())
        {
            query = query.Where(x => selectedColors.Contains(x.Color));
        }
        #endregion

        #region Sorting
        if (selectedSort != null)
        {
            query = selectedSort switch
            {
                "priceAsc" => query.OrderBy(x => x.StandardCost),
                "priceDesc" => query.OrderByDescending(x => x.StandardCost),
                "nameAsc" => query.OrderBy(x => x.Name),
                "nameDesc" => query.OrderByDescending(x => x.Name),
                _ => query.OrderBy(x => x.ProductId),
            };
        }
        #endregion

        #region Remove products with 0 cost
        query = query.Where(x => x.StandardCost > 0);
        #endregion

        #region Pagination
        query = query.Skip((page - 1) * productRequested).Take(productRequested);
        #endregion

        return query.Select(s => new ProductViewModel
        {
            ProductId = s.ProductId,
            Name = s.Name,
            ProductNumber = s.ProductNumber,
            Color = s.Color,
            StandardCost = s.StandardCost,
            ListPrice = s.ListPrice,
            ProductPhoto = s.ProductProductPhotos.FirstOrDefault().ProductPhoto.LargePhoto,
        }).ToList();
    }


    /// <summary>
    /// Get all categories
    /// </summary>
    /// <returns></returns>
    public List<CategoryViewModel> GetCategories()
    {
        return _context.ProductCategories
            .Include(pc => pc.ProductSubcategories)
            .Select(s => new CategoryViewModel
            {
                ProductCategoryId = s.ProductCategoryId,
                Name = s.Name
            })
            .OrderBy(x => x.ProductCategoryId)
            .ToList();
    }

    /// <summary>
    /// Get subcategories by category id
    /// </summary>
    /// <param name="categoryId"></param>
    /// <returns></returns>
    public List<SubCategoryViewModel> GetSubCategories(int categoryId)
    {
        return _context.ProductSubcategories
            .Where(x => x.ProductCategoryId == categoryId)
            .Select(s => new SubCategoryViewModel
            {
                ProductSubcategoryId = s.ProductSubcategoryId,
                Name = s.Name,
                ProductCategoryId = s.ProductCategoryId,
            })
            .OrderBy(x => x.ProductSubcategoryId)
            .ToList();
    }

    /// <summary>
    /// Get all available colors
    /// </summary>
    /// <returns></returns>
    public List<string> GetColors()
    {
        return _context.Products
        .Where(x => !string.IsNullOrEmpty(x.Color))
            .Select(x => x.Color!)
            .Distinct()
            .OrderBy(x => x)
            .ToList();
    }


}
