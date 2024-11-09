using Microsoft.EntityFrameworkCore;
using tarea_7.Components.Models;

namespace tarea_7.Components.Data
{

    public class DetentionContext : DbContext
    {
        public DbSet<ClaseDetencion> clasedetencion { get; set; }

        public DetentionContext(DbContextOptions<DetentionContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=detentions.db");


        }
    }
}
