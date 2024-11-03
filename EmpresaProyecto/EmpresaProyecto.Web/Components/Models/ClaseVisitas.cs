using System.ComponentModel.DataAnnotations;

namespace EmpresaProyecto.Web.Components.Models
{
    public class ClaseVisitas
    {
        //Teléfono
        //Nombre
        //Apellido
        //Correo electrónico
        [Key]
        public int Id { get; set; }
        public string? Telefono { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Correo { get; set; }
    }
}
