using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UndergroundConnectionsApi.Models;

namespace UndergroundConnectionsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistClassificationController : ControllerBase
    {
        private readonly UndergroundConnectionsApiContext _context;

        public ArtistClassificationController(UndergroundConnectionsApiContext context)
        {
            _context = context;
        }

        // GET: api/ArtistClassification
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArtistClassification>>> GetArtistClassifications()
        {
            return await _context.ArtistClassifications.ToListAsync();
        }

        // GET: api/ArtistClassification/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ArtistClassification>> GetArtistClassification(int id)
        {
            var artistClassification = await _context.ArtistClassifications.FindAsync(id);

            if (artistClassification == null)
            {
                return NotFound();
            }

            return artistClassification;
        }

        // PUT: api/ArtistClassification/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArtistClassification(int id, ArtistClassification artistClassification)
        {
            if (id != artistClassification.ArtistClassificationId)
            {
                return BadRequest();
            }

            _context.Entry(artistClassification).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArtistClassificationExists(id))
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

        // POST: api/ArtistClassification
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ArtistClassification>> PostArtistClassification(ArtistClassification artistClassification)
        {
            _context.ArtistClassifications.Add(artistClassification);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArtistClassification", new { id = artistClassification.ArtistClassificationId }, artistClassification);
        }

        // DELETE: api/ArtistClassification/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArtistClassification(int id)
        {
            var artistClassification = await _context.ArtistClassifications.FindAsync(id);
            if (artistClassification == null)
            {
                return NotFound();
            }

            _context.ArtistClassifications.Remove(artistClassification);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArtistClassificationExists(int id)
        {
            return _context.ArtistClassifications.Any(e => e.ArtistClassificationId == id);
        }
    }
}
