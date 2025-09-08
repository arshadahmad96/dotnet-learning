using Microsoft.AspNetCore.Mvc;
using Entities;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ProductRepository _productRepository;

    public ProductsController()
    {
        _productRepository = new ProductRepository();
    }

    // GET: api/products
    [HttpGet]
    public IEnumerable<Product> Get()
    {
        return _productRepository.GetAllProduct();
    }
    // DELETE: api/products/{id}
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var existingProduct = _productRepository.GetProductById(id);
        if (existingProduct == null)
        {
            return NotFound($"Product with ID {id} not found.");
        }

        _productRepository.DeleteProduct(existingProduct);

        return NoContent(); // 204
    }
}
