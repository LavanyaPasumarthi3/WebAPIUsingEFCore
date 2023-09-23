using HPlusSport.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HPlusSport.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopContext _context;

        public ProductsController(ShopContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task<ActionResult> GetAllProducts()
        {
            return Ok(await _context.Products.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetProduct(int id) 
        { 
            var product = await _context.Products.SingleOrDefaultAsync(p => p.Id == id);
            if(product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult> PostProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new {id=product.Id},product);
        }

        [HttpPut]
        public async Task<ActionResult> PutProduct(int id, Product product)
        {
            _context.Entry(product).State = EntityState.Modified;

            if(product == null)
            {
                return BadRequest();
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if(product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync(); 
            return product;
        }
    }
}
