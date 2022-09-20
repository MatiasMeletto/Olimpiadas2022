using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Musse.Data;
using Musse.Data.Models;
using MusseCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Musse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapaController : ControllerBase
    {
        private readonly IDbContextFactory<MuseoingContext> _dbContextFactory;

        public MapaController(IDbContextFactory<MuseoingContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        // GET: api/<ResenaController>
        [HttpGet]
        public MapaDTO Get()
        {
            MuseoingContext db = _dbContextFactory.CreateDbContext();            
            var mapaActual = db.Mapas.SingleOrDefault(m => m.Actual);
            MapaDTO mapaDTO = new MapaDTO()
            {
                MapaBase64 = mapaActual.MapaBase64,
                Nombre = mapaActual.Nombre,
                Tipo = mapaActual.Tipo
            };
            return mapaDTO;
        }

        // GET api/<ResenaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ResenaController>
        [HttpPost]
        public void Post([FromBody] MapaDTO value)
        {
            MuseoingContext db = _dbContextFactory.CreateDbContext();
            db.Mapas.Add(new MapaActual()
            {
                MapaBase64 = value.MapaBase64,
                Nombre = value.Nombre,
                Tipo = value.Tipo
            });
            db.SaveChanges();
        }

        // PUT api/<ResenaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ResenaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
