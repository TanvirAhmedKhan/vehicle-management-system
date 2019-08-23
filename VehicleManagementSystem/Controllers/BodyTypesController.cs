using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VehicleManagementSystem.Data;
using VehicleManagementSystem.Models.BodyType;

namespace VehicleManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BodyTypesController : ControllerBase
    {
        private readonly VehicleContext _context;

        public BodyTypesController(VehicleContext context)
        {
            _context = context;
        }

        // GET: api/BodyTypes
        [HttpGet]
        public IEnumerable<BodyTypes> GetbodyTypes()
        {
            return _context.bodyTypes;
        }

        // GET: api/Vehicles/getBodyTypesByVehicleType/

        [HttpGet("getBodyTypesByVehicleType/{vehicletype}")]
        public IActionResult GetBodyTypesByVehicleType([FromRoute] string vehicletype)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bodyTypes = _context.bodyTypes
                                      .Where(s => s.VehicleType == vehicletype)
                                      .ToList();

            if (bodyTypes == null)
            {
                return NotFound();
            }

            return Ok(bodyTypes);
        }

        // GET: api/BodyTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBodyTypes([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bodyTypes = await _context.bodyTypes.FindAsync(id);

            if (bodyTypes == null)
            {
                return NotFound();
            }

            return Ok(bodyTypes);
        }

        // PUT: api/BodyTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBodyTypes([FromRoute] int id, [FromBody] BodyTypes bodyTypes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bodyTypes.Id)
            {
                return BadRequest();
            }

            _context.Entry(bodyTypes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BodyTypesExists(id))
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

        // POST: api/BodyTypes
        [HttpPost]
        public async Task<IActionResult> PostBodyTypes([FromBody] BodyTypes bodyTypes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.bodyTypes.Add(bodyTypes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBodyTypes", new { id = bodyTypes.Id }, bodyTypes);
        }

        // DELETE: api/BodyTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBodyTypes([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bodyTypes = await _context.bodyTypes.FindAsync(id);
            if (bodyTypes == null)
            {
                return NotFound();
            }

            _context.bodyTypes.Remove(bodyTypes);
            await _context.SaveChangesAsync();

            return Ok(bodyTypes);
        }

        private bool BodyTypesExists(int id)
        {
            return _context.bodyTypes.Any(e => e.Id == id);
        }
    }
}