using Microsoft.EntityFrameworkCore;
using Model;

using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql;

namespace Contexto
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){
            // options.UseMySql( "Server=localhost;port=3306;Database=ef;User=root;Password=;" );
        }

        public DbSet<Usuario> Usuarios { get; set;}
    }
}