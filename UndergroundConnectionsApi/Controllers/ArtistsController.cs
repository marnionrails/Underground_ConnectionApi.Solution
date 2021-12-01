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
  public class ArtistsController : ControllerBase
  {
    private readonly UndergroundConnectionsApiContext _db;

    public ArtistsController(UndergroundConnectionsApiContext db)
    {
      _db = db;
    }

    // GET api/artists

      [HttpGet]
    public async Task<ActionResult<IEnumerable<Artist>>> Get(string name, int age, string email, string seeking, string pastWork)
    {
      var query = _db.Artists.AsQueryable();
      if (name != null)
      {
        query = query.Where(e => e.Name == name);
      }
      if (age > 0)
      {
        query = query.Where(e => e.Age == age);
      }
      if (email != null)
      {
        query = query.Where(e => e.Email == email);
      }
      if (seeking!= null)
      {
        query = query.Where(e => e.Seeking == seeking);
      }
      if (pastWork!= null)
      {
        query = query.Where(e => e.PastWork == pastWork);
      }
      return await query.ToListAsync();
    }


    // POST api/artists
    [HttpPost]
    public async Task<ActionResult<Artist>> Post(Artist artist)
    {
      _db.Artists.Add(artist);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = artist.ArtistId }, artist);
    }

    //Get api/Artists/?
    [HttpGet("{id}")]
    public async Task<ActionResult<Artist>> GetArtist(int id)
    {
      var artist = await _db.Artists.FindAsync(id);
      if (artist == null)
      {
        return NotFound();
      }
      return artist;
    }
    // PUT: api/Artists/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Artist artist)
    {
      if (id != artist.ArtistId)
      {
        return BadRequest();
      }

      _db.Entry(artist).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ArtistExists(id))
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

    private bool ArtistExists(int id)
    {
      return _db.Artists.Any(e => e.ArtistId == id);
    }
// DELETE: api/Artists/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteArtist(int id)
    {
      var artist = await _db.Artists.FindAsync(id);
      if (artist == null)
      {
        return NotFound();
      }

      _db.Artists.Remove(artist);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}