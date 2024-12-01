using Microsoft.EntityFrameworkCore;
using Tarea10.Components.Models.Entities;

namespace Tarea10.Components.Data
{
    public class DataContext : DbContext
    {
        public DbSet<CellData> Cells { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
