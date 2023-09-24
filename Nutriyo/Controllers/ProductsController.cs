using Microsoft.AspNetCore.Mvc;
using Nutriyo.Contracts.Products;

namespace Nutriyo.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet("{id:guid}")]
    public IActionResult GetProduct(Guid id)
    {
        return Ok(id);
    }

    [HttpPost]
    public IActionResult CreateProduct(CreateProductRequest request)
    {
        return Ok(request);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpdateProduct(Guid id)
    {
        return Ok(id);
    }
    
    [HttpDelete("{id:guid}")]
    public IActionResult DeleteProduct(Guid id)
    {
        return Ok(id);
    }

}