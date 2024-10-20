using Microsoft.EntityFrameworkCore;
public class VideoJuegosContext : DbContext{

    public DbSet<ClaseVideoJuegos> ColecciondeEntidadesClaseVideoJuegos {get; set;}

    public DbSet<ClasePersonaje> ColecciondeEntidadesClasePersonajes {get; set;} 

    public DbSet<ClasePlataformas> ColecciondeEntidadesClasePlataforma {get; set;}


    public VideoJuegosContext(DbContextOptions<VideoJuegosContext> options) 
        : base(options) {}
    
}