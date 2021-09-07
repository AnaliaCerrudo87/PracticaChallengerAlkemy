using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengerDisney.Entities
{
    public class Personaje
    {
        public int Id { get; set; }

        public string Imagen { get; set; }
        public string Nombre { set; get; }
        public int Edad { set; get; }
        public float Peso { get; set; }
        public string Historia { get; set; }
        public virtual ICollection<PeliculaSerie> PeliculaSeries { get; set; }
    }
}
