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
    public class PersonajeController : ControllerBase
    {

        private readonly ChallengerContext _context;

        public PersonajeController(ChallengerContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_context.Personaje.ToList());
        }


        [HttpPost]

        public IActionResult Post(Personaje personaje)
        {
            _context.Personaje.Add(personaje);
            _context.SaveChanges();
            return Ok(_context.Personaje.ToList());
        }

        [HttpPut]

        public IActionResult Put(Personaje personaje)
        {
            if (_context.Personaje.FirstOrDefault(x => x.Id == personaje.Id) == null) 
                return BadRequest("El Personaje que sea Modificar no existe");

            var internalPersonaje = _context.Personaje.Find(personaje.Id);
            
            internalPersonaje.Imagen=personaje.Imagen;
            internalPersonaje.Nombre = personaje.Nombre;
            internalPersonaje.Edad = personaje.Edad;
            internalPersonaje.Historia = personaje.Historia;
            internalPersonaje.Peso = personaje.Peso;
            _context.SaveChanges();
            return Ok(_context.Personaje.ToList());
        }

        [HttpDelete]
        [Route("id")]
        public IActionResult Delete(int id)
        {
            if (_context.Personaje.FirstOrDefault(x => x.Id == id) == null)
                return BadRequest("El Personaje que desea Eliminar no existe");

            var internalPersonaje = _context.Personaje.Find(id);
            _context.Personaje.Remove(internalPersonaje);
            _context.SaveChanges();
            return Ok(_context.Personaje.ToList());
        }
    }
}
