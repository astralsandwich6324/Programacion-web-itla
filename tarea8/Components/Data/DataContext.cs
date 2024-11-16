using Microsoft.EntityFrameworkCore;
using tarea8.Components.Models;

namespace tarea8.Components.Data{
    public class DetencionContext : DbContext{
        public DetencionContext(DbContextOptions<DetencionContext> options): base(options){}

        public DbSet<ClaseDentencion> ColeccionClaseDentencion {get; set;}
    }
}