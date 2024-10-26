using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sample.API.DTO;
using SamplePizza.Data;

namespace Sample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly SamplePizzaContext _samplePizzaContext;

        public ProductController(SamplePizzaContext samplePizzaContext)
        {
            _samplePizzaContext = samplePizzaContext;
        }

        [HttpGet]
        public async Task<List<ProductDTO>> GetProducts()
        {
            return await _samplePizzaContext.Products.Select(s => new ProductDTO()
            {
                Id = s.Id, Name = s.Name, Price = s.Price,
            }).ToListAsync();
        }
    }
}
