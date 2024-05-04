using Construction.API.Data;
using Construction.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Construction.API.Controllers
{

    [ApiController]
    [Route("/api/materiales")]
    public class MaterialesController : ControllerBase
    {
        private readonly DataContext _context;

        public MaterialesController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Materiales.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(Material material)
        {
            _context.Add(material);
            await _context.SaveChangesAsync();
            return Ok(material);
        }

        //Método Get- por Id
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var material = await
            _context.Materiales.SingleOrDefaultAsync(x => x.Id == id);

            if (material == null)
            {
                return NotFound();
            }
            return Ok(material);
        }

        //Método de actualizar
        [HttpPut]
        public async Task<ActionResult> Put(Material material)
        {
            _context.Update(material);
            await _context.SaveChangesAsync();
            return Ok(material);
        }

        //Método de borrar
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {


            var FilasAfectadas = await _context.Materiales

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