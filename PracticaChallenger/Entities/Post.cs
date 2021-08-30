using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaChallenger.Entities
{
    public class Post
    {
        public int Id { set; get; }
        public string Title { set; get; }

        public DateTime Date { set; get; }

        public string Content { set; get; }

        public Usuario User { set; get; }
    }
}
