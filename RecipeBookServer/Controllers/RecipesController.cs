using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeBook.Data;
using RecipeBook.Entities;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace RecipeBookServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly RecipeBookContext _context;

        public RecipesController(RecipeBookContext context)
        {
            _context = context;
        }

        // GET: api/Recipes
        /// <summary>
        /// This is lieing and returning Ingredients
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Ingredient>> Get()
        {
            return await _context.Ingredients.ToListAsync();
        }

        // GET: api/Recipes/5
        [HttpGet("{id}", Name = "Get")]
        [ProducesResponseType(201)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<Recipe>> Get(int id)
        {
            var recipe = await _context.Recipes.SingleOrDefaultAsync(r => r.Id == id);
            if (recipe == null)
            {
                return NotFound();
            }
            return recipe;
        }

        // GET: api/Recipes/Details/5
        [HttpGet("Details/{id}", Name = "Details")]
        public string Details(int id)
        {
            return "value";
        }

        // POST: api/Recipes
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Recipes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
