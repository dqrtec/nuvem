using Microsoft.EntityFrameworkCore;

namespace Contexto
{
    public class PomeloContext : DbContext
    {
        public PomeloContext(DbContextOptions<PomeloContext> options) : base(options)
        {

        }
    }
}