using System.ComponentModel.DataAnnotations;

namespace tarea_7.Components.Models
{
    public class ClaseDetencion
    {
        [Key]
        public int Id { get; set; }
        public DateTime? DetentionDate { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? PassportNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public double? Latitud { get; set; }
        public double? Longitud { get; set; }

        public string? Coordenadas()
        {
            return $"{Latitud}, {Longitud}";
        }
    }
}
