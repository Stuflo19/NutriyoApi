using Nutriyo.Models.Products;

namespace Nutriyo.Services.Products;

public class ProductService : IProductService
{
    private static readonly Dictionary<Guid, Product> Products = new();
    
    public void CreateProduct(Product product)
    {
        Products.Add(product.Id, product);
    }

    public Product GetProduct(Guid id)
    {
        return Products[id];
    }

    public void UpdateProduct(Product product)
    {
        Products[product.Id] = product;
    }

    public void DeleteProduct(Guid id)
    {
        Products.Remove(id);
    }
}