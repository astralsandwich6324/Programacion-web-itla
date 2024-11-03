using Microsoft.EntityFrameworkCore;

namespace EmpresaProyecto.Web.Components.Models
{
    public class DataContext : DbContext
    {
        public DbSet<ClaseVisitas> CollecionClaseVisitas { get; set; }

        public DataContext(DbContextOptions<DataContext>
            options) : base(options) { }
    }
}
