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
  public class ClassificationsController : ControllerBase
  {
    private readonly UndergroundConnectionsApiContext _db;

    public ClassificationsController(UndergroundConnectionsApiContext db)
    {
      _db = db;
    }

    // GET api/classifications
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Classification>>> Get(string name, string specification)
    {
      var query = _db.Classifications.AsQueryable();
      if (name != null)
      {
        query = query.Where(e => e.ClassificationName == name);
      }
      if (specification != null)
      {
        query = query.Where(e => e.ClassificationSpecification == specification);
      }
      return await query.ToListAsync();
    }

    //POST api/classifications
    [HttpPost]
    public async Task<ActionResult<Classification>> Post(Classification classification)
    {
      _db.Classifications.Add(classification);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = classification.ClassificationId }, classification);
    }


    //Get api/Classifications/?
    [HttpGet("{id}")]
    public async Task<ActionResult<Classification>> GetClassification(int id)
    {
      var classification = await _db.Classifications.FindAsync(id);
      if (classification == null)
      {
        return NotFound();
      }
      return classification;
    }
    // PUT: api/Classification/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Classification classification)
    {
      if (id != classification.ClassificationId)
      {
        return BadRequest();
      }

      _db.Entry(classification).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ClassificationExists(id))
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

    private bool ClassificationExists(int id)
    {
      return _db.Classifications.Any(e => e.ClassificationId == id);
    }
    // DELETE: api/Classifications/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteClassification(int id)
    {
      var classification = await _db.Classifications.FindAsync(id);
      if (classification == null)
      {
        return NotFound();
      }

      _db.Classifications.Remove(classification);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}