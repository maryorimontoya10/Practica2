
using Construction.API.Data;
using Construction.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Construction.API.Controllers
{
    [ApiController]
    [Route("/api/proyectoequipos")]
    public class ProyectoEquiposController : ControllerBase
    {
        private readonly DataContext _context;

        public ProyectoEquiposController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.ProyectosEquipos.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(ProyectoEquipo proyectoequipo)
        {
            _context.Add(proyectoequipo);
            await _context.SaveChangesAsync();
            return Ok(proyectoequipo);
        }

        //Método Get- por Id
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var proyectoequipo = await
            _context.ProyectosEquipos.SingleOrDefaultAsync(x => x.Id == id);

            if (proyectoequipo == null)
            {
                return NotFound();
            }
            return Ok(proyectoequipo);
        }

        //Método de actualizar
        [HttpPut]
        public async Task<ActionResult> Put(ProyectoEquipo proyectoequipo)
        {
            _context.Update(proyectoequipo);
            await _context.SaveChangesAsync();
            return Ok(proyectoequipo);
        }

        //Método de borrar
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {


            var FilasAfectadas = await _context.ProyectosEquipos

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

