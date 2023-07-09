using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPICODEFIRST.Model;
using WebAPICODEFIRST.Model.Data;

namespace WebAPICODEFIRST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BikesController : ControllerBase
    {
        private readonly BikeDataContext _context;

        public BikesController(BikeDataContext context)
        {
            _context = context;
        }

        // GET: api/Bikes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bike>>> GetBikes()
        {
          if (_context.Bikes == null)
          {
              return NotFound();
          }
            return await _context.Bikes.ToListAsync();
        }

        // GET: api/Bikes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bike>> GetBike(string id)
        {
          if (_context.Bikes == null)
          {
              return NotFound();
          }
            var bike = await _context.Bikes.FindAsync(id);

            if (bike == null)
            {
                return NotFound();
            }

            return bike;
        }

        // PUT: api/Bikes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBike(string id, Bike bike)
        {
            if (id != bike.Bike_Name)
            {
                return BadRequest();
            }

            _context.Entry(bike).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BikeExists(id))
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

        // POST: api/Bikes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bike>> PostBike(Bike bike)
        {
          if (_context.Bikes == null)
          {
              return Problem("Entity set 'BikeDataContext.Bikes'  is null.");
          }
            _context.Bikes.Add(bike);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BikeExists(bike.Bike_Name))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBike", new { id = bike.Bike_Name }, bike);
        }

        // DELETE: api/Bikes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBike(string id)
        {
            if (_context.Bikes == null)
            {
                return NotFound();
            }
            var bike = await _context.Bikes.FindAsync(id);
            if (bike == null)
            {
                return NotFound();
            }

            _context.Bikes.Remove(bike);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BikeExists(string id)
        {
            return (_context.Bikes?.Any(e => e.Bike_Name == id)).GetValueOrDefault();
        }
    }
}
