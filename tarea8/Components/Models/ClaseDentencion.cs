using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


/* Fecha de la detención
👤 Nombre y apellido
🛂 Número de pasaporte
🎂 Fecha de nacimiento
📍 Coordenadas de la detención*/

namespace tarea8.Components.Models
{
    public class ClaseDentencion
    {
        [Key]
        public int Id {get; set;}

        [Required]
        public DateTime? FechaDetencion {get; set;}

        [Required]
        [MaxLength(50)]
        public string? Name {get; set;}

        [Required]
        [MaxLength(50)]
        public string? Apellido {get; set;}

        [Required]
        [MaxLength(10)]
        public string? PassportNumber {get; set;}

        [Required]
        public DateTime? FechaNacimiento {get; set;}

        public double Latitud {get;set;}
        public double Longitud {get;set;}

        public string? Coordenadas(){
           return $"{Latitud}, {Longitud}";
        }

    }
}