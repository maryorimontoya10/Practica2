using Construction.API.Data;
using Construction.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Construction.API.Controllers
{

    [ApiController]
    [Route("/api/proyectos")]
    public class ProyectosController : ControllerBase
    {
        private readonly DataContext _context;

        public ProyectosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Proyectos.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(Proyecto proyecto)
        {
            _context.Add(proyecto);
            await _context.SaveChangesAsync();
            return Ok(proyecto);
        }

        //Método Get- por Id
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var proyecto = await
            _context.Proyectos.SingleOrDefaultAsync(x => x.Id == id);

            if (proyecto == null)
            {
                return NotFound();
            }
            return Ok(proyecto);
        }

        //Método de actualizar
        [HttpPut]
        public async Task<ActionResult> Put(Proyecto proyecto)
        {
            _context.Update(proyecto);
            await _context.SaveChangesAsync();
            return Ok(proyecto);
        }

        //Método de borrar
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {


            var FilasAfectadas = await _context.Proyectos

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