using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction.Shared.Entities
{
    public class Maquinaria
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nombre { get; set; }

        [Display(Name = "Capacidad")]
        [MaxLength(10, ErrorMessage = "No se permiten más de 10 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int Capacidad { get; set; }

        [Display(Name = "Estado")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Estado { get; set; }

        [Display(Name = "Disponibilidad")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public bool Disponibilidad { get; set; }
    }
}
