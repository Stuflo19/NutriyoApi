using Microsoft.AspNetCore.Mvc;
using Nutriyo.Contracts.Products;
using Nutriyo.Models.Products;
using Nutriyo.Services.Products;
using NutritionalInformation = Nutriyo.Contracts.Products.NutritionalInformation;

namespace Nutriyo.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ApiController
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    private static ProductResponse MapProductResponse(Product product) => new(
        product.Id,
        product.Name,
        product.Barcodes,
        product.Weight,
        product.LastUpdated,
        product.PerHundredGrams,
        product.Total
    );

    private CreatedAtActionResult CreatedAtActionResult(Product product)
    {
        return CreatedAtAction(nameof(GetProduct), new {id = product.Id}, MapProductResponse(product));
    }
    
    [HttpGet("{id:guid}")]
    public IActionResult GetProduct(Guid id)
    {
        var getProductResult = _productService.GetProduct(id);

        return getProductResult.Match(product => Ok(MapProductResponse(product)), Problem);
    }

    [HttpPost]
    public IActionResult CreateProduct(CreateProductRequest request)
    {
        var product = Product.From(request);
        
        var createBreakfastResult = _productService.CreateProduct(product);

        return createBreakfastResult.Match(created => CreatedAtActionResult(product), Problem);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpdateProduct(Guid id, UpdateProductRequest request)
    {
        var product = Product.From(id, request);
        
        var updateProductResult = _productService.UpdateProduct(product);

        updateProductResult.Match(updated => updated.IsNewlyCreated ? CreatedAtActionResult(product) : NoContent(), Problem);
        return Ok(product);
    }
    
    [HttpDelete("{id:guid}")]
    public IActionResult DeleteProduct(Guid id)
    {
        var deleteProductResult = _productService.DeleteProduct(id);

        return deleteProductResult.Match(deleted => NoContent(), Problem);
    }

}