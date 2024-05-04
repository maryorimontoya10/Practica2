using Construction.API.Data;
using Construction.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Construction.API.Controllers
{
    [ApiController]
    [Route("/api/tareas")]
    public class TareasController : ControllerBase
    {
        private readonly DataContext _context;

        public TareasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Tareas.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(Tarea tarea)
        {
            _context.Add(tarea);
            await _context.SaveChangesAsync();
            return Ok(tarea);
        }

        //Método Get- por Id
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var tarea = await
            _context.Tareas.SingleOrDefaultAsync(x => x.Id == id);

            if (tarea == null)
            {
                return NotFound();
            }
            return Ok(tarea);
        }

        //Método de actualizar
        [HttpPut]
        public async Task<ActionResult> Put(Tarea tarea)
        {
            _context.Update(tarea);
            await _context.SaveChangesAsync();
            return Ok(tarea);
        }

        //Método de borrar
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {


            var FilasAfectadas = await _context.Tareas

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
