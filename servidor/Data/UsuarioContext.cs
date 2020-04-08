using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using Pomelo.EntityFrameworkCore.MySql;

using Model;

namespace Contexto
{
  public class UsuarioContext : DbContext
  {
    string TODO_CONNECTION_STRING = "";
    public DbSet<Usuario> Usuarios { get; set; }
    public UsuarioContext()
    {
      TODO_CONNECTION_STRING = "Server=localhost;Port=3306;Database=database1;Uid=root;";
      // TODO_CONNECTION_STRING = "Server=database-1.cgognr9jnz8a.us-east-2.rds.amazonaws.com;Port=3306;Uid=admin;Pwd=admin123;";
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
        optionsBuilder.UseMySql(TODO_CONNECTION_STRING);
        base.OnConfiguring(optionsBuilder);
      }
    }
}