using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Construction.API.Data;
using Construction.Shared.Entities;


namespace Construction.API.Controllers
{
    [ApiController]
    [Route("/api/equipos")]
    public class EquiposController : ControllerBase
    {
        private readonly DataContext _context;

        public EquiposController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Equipos.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(Equipo equipo)
        {
            _context.Add(equipo);
            await _context.SaveChangesAsync();
            return Ok(equipo);
        }

        //Método Get- por Id
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var equipo = await
            _context.Equipos.SingleOrDefaultAsync(x => x.Id == id);

            if (equipo == null)
            {
                return NotFound();
            }
            return Ok(equipo);
        }

        //Método de actualizar
        [HttpPut]
        public async Task<ActionResult> Put(Equipo equipo)
        {
            _context.Update(equipo);
            await _context.SaveChangesAsync();
            return Ok(equipo);
        }

        //Método de borrar
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {


            var FilasAfectadas = await _context.Equipos

                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (FilasAfectadas == 0)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
