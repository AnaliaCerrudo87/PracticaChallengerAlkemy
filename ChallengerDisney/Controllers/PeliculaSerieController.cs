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
    public class PeliculaSerieController:ControllerBase
    {
        private readonly ChallengerContext _context;

        public PeliculaSerieController(ChallengerContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_context.PeliculaSerie.ToList());
        }


        [HttpPost]

        public IActionResult Post(PeliculaSerie peli)
        {
            _context.PeliculaSerie.Add(peli);
            _context.SaveChanges();
            return Ok(_context.PeliculaSerie.ToList());
        }

        [HttpPut]

        public IActionResult Put(PeliculaSerie peli)
        {
            if (_context.PeliculaSerie.FirstOrDefault(x => x.Id == peli.Id) == null)
                return BadRequest("La Pelicula o Serie que sea Modificar no existe");

            var internalPeliculaSerie = _context.PeliculaSerie.Find(peli.Id);

            internalPeliculaSerie.Imagen = peli.Imagen;
            internalPeliculaSerie.Titulo = peli.Titulo;
            internalPeliculaSerie.Calificacion = peli.Calificacion;
            internalPeliculaSerie.FechaCreacion = peli.FechaCreacion;


            _context.SaveChanges();
            return Ok(_context.PeliculaSerie.ToList());
        }

        [HttpDelete]
        [Route("id")]
        public IActionResult Delete(int id)
        {
            if (_context.PeliculaSerie.FirstOrDefault(x => x.Id == id) == null)
                return BadRequest("La Pelicula o Serie que desea Eliminar no existe");

            var internalPeliculaSerie = _context.PeliculaSerie.Find(id);
            _context.PeliculaSerie.Remove(internalPeliculaSerie);
            _context.SaveChanges();
            return Ok(_context.PeliculaSerie.ToList());
        }

    }
}
