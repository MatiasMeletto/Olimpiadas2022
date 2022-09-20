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
        private readonly MuseoingContext _dbContext;

        public MapaController(MuseoingContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/<MapaController>
        [HttpGet]
        public MapaDTO Get()
        {
            MapaDTO mapaDTO = new MapaDTO();
            MapaActual? mapa = _dbContext.Mapas.Where(m => m.Actual).AsNoTracking().SingleOrDefault();
            if (mapa is not null)
            {
                mapaDTO = new MapaDTO()
                {
                    MapaBase64 = mapa.MapaBase64,
                    Tipo = mapa.Tipo,
                    Nombre = mapa.Nombre,
                };
            }
            return mapaDTO;
        }

        // GET api/<MapaController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<MapaController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        // PUT api/<MapaController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<MapaController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
