using ChallengerDisney.Context;
using ChallengerDisney.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengerDisney.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GeneroController : ControllerBase
    {
        private readonly ChallengerContext _context;

        public GeneroController(ChallengerContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_context.Genero.ToList());
        }


        [HttpPost]

        public IActionResult Post(Genero genero)
        {
            _context.Genero.Add(genero);
            _context.SaveChanges();
            return Ok(_context.Genero.ToList());
        }

        [HttpPut]

        public IActionResult Put(Genero genero)
        {
            if (_context.Genero.FirstOrDefault(x => x.Id == genero.Id) == null)
                return BadRequest("El Genero que sea Modificar no existe");

            var internalGenero = _context.Genero.Find(genero.Id);

            internalGenero.Imagen = genero.Imagen;
            internalGenero.Nombre = genero.Nombre;
            
            _context.SaveChanges();
            return Ok(_context.Genero.ToList());
        }

        [HttpDelete]
        [Route("id")]
        public IActionResult Delete(int id)
        {
            if (_context.Genero.FirstOrDefault(x => x.Id == id) == null)
                return BadRequest("El Genero que desea Eliminar no existe");

            var internalGenero = _context.Genero.Find(id);
            _context.Genero.Remove(internalGenero);
            _context.SaveChanges();
            return Ok(_context.Genero.ToList());
        }
    }

}

