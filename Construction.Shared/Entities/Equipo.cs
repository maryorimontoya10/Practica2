using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Construction.Shared.Entities
{
    public class Equipo
    {
        public int Id { get; set; }

        [Display(Name ="Nombre")]
        [MaxLength(50, ErrorMessage ="No se permiten más de 50 caracteres")]
        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        public string Nombre { get; set; }


        [Display(Name = "Especialidad")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Especialidad { get; set;}

        [Display(Name = "Lista de miembros")]
        [MaxLength(250, ErrorMessage = "No se permiten más de 250 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string ListaMiembros { get; set; }

        //Relaciones

        [JsonIgnore]
        public ICollection<ProyectoEquipo> ProyectosEquipos { get; set; }

    }
}
