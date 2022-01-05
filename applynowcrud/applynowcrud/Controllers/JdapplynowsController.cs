using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using applynowcrud.Models;

namespace applynowcrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JdapplynowsController : ControllerBase
    {
        private readonly jdContext _context;

        public JdapplynowsController(jdContext context)
        {
            _context = context;
        }

        // GET: api/Jdapplynows
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Jdapplynow>>> GetJdapplynows()
        {
            return await _context.Jdapplynows.ToListAsync();
        }

        // GET: api/Jdapplynows/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Jdapplynow>> GetJdapplynow(int id)
        {
            var jdapplynow = await _context.Jdapplynows.FindAsync(id);

            if (jdapplynow == null)
            {
                return NotFound();
            }

            return jdapplynow;
        }

        // PUT: api/Jdapplynows/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJdapplynow(int id, Jdapplynow jdapplynow)
        {
            if (id != jdapplynow.ApplyId)
            {
                return BadRequest();
            }

            _context.Entry(jdapplynow).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JdapplynowExists(id))
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

        // POST: api/Jdapplynows
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Jdapplynow>> PostJdapplynow(Jdapplynow jdapplynow)
        {
            _context.Jdapplynows.Add(jdapplynow);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJdapplynow", new { id = jdapplynow.ApplyId }, jdapplynow);
        }

        // DELETE: api/Jdapplynows/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJdapplynow(int id)
        {
            var jdapplynow = await _context.Jdapplynows.FindAsync(id);
            if (jdapplynow == null)
            {
                return NotFound();
            }

            _context.Jdapplynows.Remove(jdapplynow);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JdapplynowExists(int id)
        {
            return _context.Jdapplynows.Any(e => e.ApplyId == id);
        }
    }
}
