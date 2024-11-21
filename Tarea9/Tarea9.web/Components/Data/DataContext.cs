using Microsoft.EntityFrameworkCore;
using Tarea9.web.Components.Models;

namespace Tarea9.Web.Components.Data
{
    public class DataContext : DbContext
    {
        public DbSet<ClaseLogin> ColeccionInicioSecion { get; set; }

        public DbSet<DateTimeRegistroVivencias> ColeccionDateTimeRV { get; set; }

        public DbSet<DateTimeListadoVivencias> ColeccionDateTimeLV { get; set; }

        public DbSet<Vivencias> Coleccionvivivencias { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        
    }
}
