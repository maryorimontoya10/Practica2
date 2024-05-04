using Construction.API.Data;
using Construction.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Construction.API.Controllers
{

    [ApiController]
    [Route("/api/presupuestos")]
    public class PresupuestosController : ControllerBase
    {
        private readonly DataContext _context;

        public PresupuestosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Presupuestos.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(Presupuesto presupuesto)
        {
            _context.Add(presupuesto);
            await _context.SaveChangesAsync();
            return Ok(presupuesto);
        }

        //Método Get- por Id
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var presupuesto = await
            _context.Presupuestos.SingleOrDefaultAsync(x => x.Id == id);

            if (presupuesto == null)
            {
                return NotFound();
            }
            return Ok(presupuesto);
        }

        //Método de actualizar
        [HttpPut]
        public async Task<ActionResult> Put(Presupuesto presupuesto)
        {
            _context.Update(presupuesto);
            await _context.SaveChangesAsync();
            return Ok(presupuesto);
        }

        //Método de borrar
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {


            var FilasAfectadas = await _context.Presupuestos

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