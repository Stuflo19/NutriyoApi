using Microsoft.AspNetCore.Mvc;
using Nutriyo.Contracts.Products;
using Nutriyo.Models.Products;
using Nutriyo.Services.Products;

namespace Nutriyo.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetProduct(Guid id)
    {
        var product = _productService.GetProduct(id);
        
        return Ok(product);
    }

    [HttpPost]
    public IActionResult CreateProduct(CreateProductRequest request)
    {
        var product = Product.From(request);
        
        _productService.CreateProduct(product);
        
        return Ok(product);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpdateProduct(Guid id, UpdateProductRequest request)
    {
        var product = Product.From(id, request);
        
        _productService.UpdateProduct(product);
        
        return Ok(product);
    }
    
    [HttpDelete("{id:guid}")]
    public IActionResult DeleteProduct(Guid id)
    {
        _productService.DeleteProduct(id);
        return Ok(id);
    }

}