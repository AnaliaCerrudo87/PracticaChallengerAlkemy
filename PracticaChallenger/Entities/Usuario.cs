using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaChallenger.Entities
{
    public class Usuario
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public string Password { set; get; }

        public string Email { set; get; }

        public ICollection<Post> Post { set; get; }

        public ICollection<Comments> Comments { set; get; }
    }
}
