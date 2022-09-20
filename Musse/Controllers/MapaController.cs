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
        public IEnumerable<MapaDTO> Get()
        {
            MapaActual? mapa = _dbContext.Mapas.Where(m => m.Actual).AsNoTracking().SingleOrDefault();
            List<MapaDTO> mapasDTO = new List<MapaDTO>();
            if (mapa is not null)
            {
                MapaDTO mapaDTO = new MapaDTO()
                {
                    MapaBase64 = mapa.MapaBase64,
                    Tipo = mapa.Tipo,
                    Nombre = mapa.Nombre,
                };
                mapasDTO.Add(mapaDTO);
            }
            return mapasDTO;
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
