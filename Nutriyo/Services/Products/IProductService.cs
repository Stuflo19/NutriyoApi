using Nutriyo.Models.Products;

namespace Nutriyo.Services.Products;

public interface IProductService
{
    void CreateProduct(Product product);
    
    Product GetProduct(Guid id);
    
    void UpdateProduct(Product product);
    
    void DeleteProduct(Guid id);
}