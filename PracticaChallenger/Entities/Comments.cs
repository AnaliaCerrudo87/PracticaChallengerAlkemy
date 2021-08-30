using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaChallenger.Entities
{
    public class Comments
    {

        public int Id { set; get; }

        public DateTime Date { set; get; }

        public string Comment { set; get; }

        public Usuario User { set; get; } //Entendiendo que un Comentario puede tener un solo usuario
    }
}
