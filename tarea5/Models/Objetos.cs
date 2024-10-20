
using System.ComponentModel.DataAnnotations;

public class ClaseVideoJuegos{
    public int Id {get; set;}
    public string? Nombre {get; set;}
    public string? Desarrollador {get; set;}
    public string? Plataforma {get; set;}
    public string? Genero {get; set;}
    public DateTime FechaDeLanzamiento {get; set;}
    public string? ImagenDePortada {get; set;}
    public string Descripcion {get; set;} ="";

public List<ClasePersonaje> nommbreDeLista_Personajes {get; set;} = new List<ClasePersonaje>();

}

public class ClasePersonaje{
    [Key]
    public int Id_personaje {get; set;}

    public string? Nombre {get; set;}
    public string? Alias {get; set;}

    public string? Rol {get; set;}

    public string? Habilidad {get; set;}
    public string? ArmaFavorita {get; set;}

    public int NivelDePoder {get; set;}
    public string? FotoDelPersonaje {get; set;}

}


public class ClasePlataformas{
    [Key]
    public int Id_Plataformas {get; set;}
    public string? Nombredelaplataforma {get;set;}
    public bool Estado {get; set;}

}