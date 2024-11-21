using System.Runtime.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace Tarea9.web.Components.Models
{
    public class Vivencias 
    {

        //Título de la vivencia
        //Descripción detallada
        //Fecha de la vivencia
        //Imagen opcional que represente la experiencia

        public int Id { get; set; }

        public string? Titulo { get; set; }

        public string? Descripcion { get; set; }

        public DateTime? FechaVivencia { get; set; }

        public DateTime? UltimaModificacion { get; set; } = DateTime.Now;

        public string? Url { get; set; } = "img/me.png";

        public void DefaultUrl()
        {
            if (string.IsNullOrWhiteSpace(Url))  
            {
                Url = "img/me.png";  
            }
        }

        public string? TextoImagen { get; set; } = "Escribe texto opcional";

        public void DefaultText()
        {
            if (string.IsNullOrWhiteSpace(TextoImagen))
            {
                TextoImagen = "Error, imagen no cargó correctamente";
            }
        }

        public string UsuarioId { get; set; }
    }
}
