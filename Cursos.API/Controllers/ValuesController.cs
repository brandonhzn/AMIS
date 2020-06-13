using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    // http:localhost:5000/api/values
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;

        }
        // GET api/values
        [HttpGet]  
        [AllowAnonymous]      
        public async Task<IActionResult> ObtenerCursos()
        {
            var values = await _context.Cursos.ToListAsync();
            return Ok(values);
        }

        // GET api/values/5
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerPersonasPorCurso(int id)
        {          
            var Value = (from cust in _context.UnionCursoUser
                                       where cust.Curso.Id == id
                                       select cust.user);
            return Ok(Value);
        }

        // POST api/values
        [AllowAnonymous]        
        //[HttpPost("Rango")]
        [HttpGet("{edad}")]
        public async Task<IActionResult> RangosPorEdades(int edad)
        {          
            var Value = (from cust in _context.UnionCursoUser
                                       where (cust.user.FechaNacimiento - DateTime.Now ).TotalDays < edad 
                                       select cust.user);
            return Ok(Value);
        }


        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
