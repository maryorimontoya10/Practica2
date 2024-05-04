using Construction.API.Data;
using Construction.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Construction.API.Controllers
{

    [ApiController]
    [Route("/api/maquinarias")]
    public class MaquinariasController : ControllerBase
    {
        private readonly DataContext _context;

        public MaquinariasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Maquinarias.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(Maquinaria maquinaria)
        {
            _context.Add(maquinaria);
            await _context.SaveChangesAsync();
            return Ok(maquinaria);
        }

        //Método Get- por Id
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var maquinaria = await
            _context.Maquinarias.SingleOrDefaultAsync(x => x.Id == id);

            if (maquinaria == null)
            {
                return NotFound();
            }
            return Ok(maquinaria);
        }

        //Método de actualizar
        [HttpPut]
        public async Task<ActionResult> Put(Maquinaria maquinaria)
        {
            _context.Update(maquinaria);
            await _context.SaveChangesAsync();
            return Ok(maquinaria);
        }

        //Método de borrar
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {


            var FilasAfectadas = await _context.Maquinarias

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
