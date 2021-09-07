using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengerDisney.Entities
{
    public class PeliculaSerie
    {
        public int Id { get; set; }
        public string Imagen { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaCreacion { get; set; } 
       
        [Range(1,5)]
        public int Calificacion { get; set; }
        public virtual ICollection<Personaje> Personajes { get; set; }
    }
}
