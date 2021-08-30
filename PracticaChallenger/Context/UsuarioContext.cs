using Microsoft.EntityFrameworkCore;
using PracticaChallenger.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaChallenger.Context
{
    public class UsuarioContext :DbContext
    {



            public UsuarioContext(DbContextOptions options) : base(options)
            {

            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)

            {
                base.OnModelCreating(modelBuilder);
            }

            public DbSet<Usuario> User { get; set; } = null!;

            public DbSet<Post> Posts { get; set; } = null!;

            public DbSet<Comments> Comments { get; set; } = null!;

        }
    }


