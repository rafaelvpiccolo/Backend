using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Data;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context) 
        {
            _context = context;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(long id)
        {
            var product = await _context.produtos.FindAsync(id);

            if(product == null) 
            {
                return NotFound();
            }
            
            return product;
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _context.produtos.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(long id)
        {
            var product = await _context.produtos.FindAsync(id);
            if(product == null)
            {
                return NotFound();
            }

            _context.produtos.Remove(product);
            await _context.SaveChangesAsync();

            return product;
        }
    }
}
