using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubmittalsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public SubmittalsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET api/submittals
        [HttpGet]
        public async Task<ActionResult<List<Submittals>>> Get()
        {
            return await _dbContext.Submittals.ToListAsync();
        }

        // GET api/pizzavotes/{email}
        // [Authorize]
        // [HttpGet("{id}")]
        // public async Task<ActionResult<PizzaVotes>> Get(string id)
        // {
        //     return await _dbContext.PizzaVotes.FindAsync(id);
        // }

        // POST api/submittals
        // [Authorize]
        [HttpPut("{id")]
        public async Task<ActionResult> Put(string id, Submittals model)
        {
            var exists = await _dbContext.Submittals.AnyAsync(f => f.Id == id);
            if (!exists)
            {
                return NotFound();
            }

            _dbContext.Submittals.Update(model);

            await _dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}