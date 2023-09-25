using ErrorOr;
using Nutriyo.Models.Products;
using Nutriyo.ServiceErrors;

namespace Nutriyo.Services.Products;

public class ProductService : IProductService
{
    private static readonly Dictionary<Guid, Product> Products = new();
    
    public ErrorOr<Created> CreateProduct(Product product)
    {
        Products.Add(product.Id, product);

        return Result.Created;
    }

    public ErrorOr<Product> GetProduct(Guid id)
    {
        if(Products.TryGetValue(id, out var product))
        {
            return product;
        }
        
        return Errors.Product.NotFound;
    }

    public ErrorOr<UpdatedProduct> UpdateProduct(Product product)
    {
        var isNewlyCreated = !Products.ContainsKey(product.Id);
        Products[product.Id] = product;

        return new UpdatedProduct(isNewlyCreated);
    }

    public ErrorOr<Deleted> DeleteProduct(Guid id)
    {
        Products.Remove(id);

        return Result.Deleted;
    }
}