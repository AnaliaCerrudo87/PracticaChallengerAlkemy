using ChallengerDisney.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ChallengerDisney.Context
{
    public class ChallengerContext:DbContext
    {

        public ChallengerContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Personaje> Personaje { get; set; } = null!;
        public DbSet<PeliculaSerie> PeliculaSerie { get; set; } = null!;
        public DbSet<Genero> Genero { get; set; } = null!;

    }
}
