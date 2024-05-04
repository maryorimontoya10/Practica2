
using Construction.API.Data;
using Construction.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Construction.API.Controllers
{
    [ApiController]
    [Route("/api/tareasmateriales")]
    public class TareasMaterialesController : ControllerBase
    {
        private readonly DataContext _context;

        public TareasMaterialesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.TareasMateriales.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(TareaMaterial tareamaterial)
        {
            _context.Add(tareamaterial);
            await _context.SaveChangesAsync();
            return Ok(tareamaterial);
        }

        //Método Get- por Id
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var tareamaterial = await
            _context.TareasMateriales.SingleOrDefaultAsync(x => x.Id == id);

            if (tareamaterial == null)
            {
                return NotFound();
            }
            return Ok(tareamaterial);
        }

        //Método de actualizar
        [HttpPut]
        public async Task<ActionResult> Put(TareaMaterial tareamaterial)
        {
            _context.Update(tareamaterial);
            await _context.SaveChangesAsync();
            return Ok(tareamaterial);
        }

        //Método de borrar
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {


            var FilasAfectadas = await _context.TareasMateriales

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


