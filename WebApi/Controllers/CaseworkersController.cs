using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Entites;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaseworkersController : ControllerBase
    {
        private readonly DataContext _context;

        public CaseworkersController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Caseworkers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Caseworker>>> GetCaseworkers()
        {
            return await _context.Caseworkers.ToListAsync();
        }

        // GET: api/Caseworkers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Caseworker>> GetCaseworker(int id)
        {
            var caseworker = await _context.Caseworkers.FindAsync(id);

            if (caseworker == null)
            {
                return NotFound();
            }

            return caseworker;
        }

        // PUT: api/Caseworkers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCaseworker(int id, Caseworker caseworker)
        {
            if (id != caseworker.Id)
            {
                return BadRequest();
            }

            _context.Entry(caseworker).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CaseworkerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Caseworkers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Caseworker>> PostCaseworker(Caseworker caseworker)
        {
            _context.Caseworkers.Add(caseworker);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCaseworker", new { id = caseworker.Id }, caseworker);
        }

        // DELETE: api/Caseworkers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Caseworker>> DeleteCaseworker(int id)
        {
            var caseworker = await _context.Caseworkers.FindAsync(id);
            if (caseworker == null)
            {
                return NotFound();
            }

            _context.Caseworkers.Remove(caseworker);
            await _context.SaveChangesAsync();

            return caseworker;
        }

        private bool CaseworkerExists(int id)
        {
            return _context.Caseworkers.Any(e => e.Id == id);
        }
    }
}
