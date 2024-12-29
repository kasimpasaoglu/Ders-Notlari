using AdventureWorksApi.DataAccessLayer;
using Microsoft.EntityFrameworkCore;

public class Repo : IRepo
{
    private AdventureWorksContext _context;


    public Repo(AdventureWorksContext context)
    {
        _context = context;
    }
    public List<ProductViewModel> GetAllProducts(int count)
    {
        return _context.Products
            .Include(p => p.ProductProductPhotos)
            .Include(p => p.ProductModel)
                .ThenInclude(pm => pm.ProductModelProductDescriptionCultures)
                .ThenInclude(pmpdc => pmpdc.ProductDescription)
            .Include(p => p.ProductSubcategory)
                .ThenInclude(psc => psc.ProductCategory)
            .Where(x => x.StandardCost > 0 && x.ProductSubcategoryId != null)
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
            }).Take(count).ToList();
    }

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
            }
            ).FirstOrDefault();
    }

}




public interface IRepo
{
    // Define methods here
    public List<ProductViewModel> GetAllProducts(int count);
    public ProductViewModel GetProductById(int id);
}