using Microsoft.AspNetCore.Mvc;
using Musse.Data;
using Musse.Data.Models;
using MusseCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Musse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResenasController : ControllerBase
    {
        private readonly MuseoingContext _dbContext;

        public ResenasController(MuseoingContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/<ValuesController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<ValuesController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] ResenaDTO value)
        {
            ResenaComentario resena = new ResenaComentario()
            {
                Fecha = value.Fecha,
                ResenaComentarioString = value.ResenaComentarioString,
                Nota = (TipoNota)value.Nota
            };
            _dbContext.ResenasComentarios.Add(resena);
            _dbContext.SaveChanges();
        }

        // PUT api/<ValuesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ValuesController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
