using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapperBibliothekMit.NetCore6.Web.Models;
using AutoMapper;
using AutoMapperBibliothekMit.NetCore6.Web.Düoe;

namespace AutoMapperBibliothekMit.NetCore6.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KundenApiController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly AppDbKontext _context;

        public KundenApiController(IMapper mapper, AppDbKontext context)
        {
            _mapper = mapper;
            _context = context;
        }



        // GET: api/KundenApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<KundeDüo>>> GetKunden()
        {
            List<Kunde> kunden= await _context.Kunden.ToListAsync();
            return _mapper.Map<List<KundeDüo>>(kunden);
        }

        // GET: api/KundenApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Kunde>> GetKunde(int id)
        {
            var kunde = await _context.Kunden.FindAsync(id);

            if (kunde == null)
            {
                return NotFound();
            }

            return kunde;
        }

        // PUT: api/KundenApi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKunde(int id, Kunde kunde)
        {
            if (id != kunde.Id)
            {
                return BadRequest();
            }

            _context.Entry(kunde).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KundeExists(id))
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

        // POST: api/KundenApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Kunde>> PostKunde(Kunde kunde)
        {
            _context.Kunden.Add(kunde);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKunde", new { id = kunde.Id }, kunde);
        }

        // DELETE: api/KundenApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKunde(int id)
        {
            var kunde = await _context.Kunden.FindAsync(id);
            if (kunde == null)
            {
                return NotFound();
            }

            _context.Kunden.Remove(kunde);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KundeExists(int id)
        {
            return _context.Kunden.Any(e => e.Id == id);
        }
    }
}
