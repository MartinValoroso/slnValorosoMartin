using Microsoft.EntityFrameworkCore;
using slnValorosoMartin.Models;


namespace slnValorosoMartin.Data
{
    public class RecetaDBContext : DbContext
    {
        public RecetaDBContext(DbContextOptions<RecetaDBContext> options) : base(options) { }

        public DbSet<Receta> Recetas { get; set; }
    }
}
