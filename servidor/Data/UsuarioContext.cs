using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Pomelo.EntityFrameworkCore.MySql;

using Model;

namespace Contexto
{
    public class UsuarioContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Postagem> Postagems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Integrated Security=True");
            // UseSqlServer (@"Server=(localdb)\mssqllocaldb;Database=Blogging;Integrated Security=True");
        }
    }
}