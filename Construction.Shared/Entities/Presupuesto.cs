using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Construction.Shared.Entities
{
    public class Presupuesto
    {
        public int Id { get; set; }

        [Display(Name = "Presupuesto mano de obra")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public double PresupuestoManoObra { get; set; }

        [Display(Name = "Presupuesto maquinaria")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public double PresupuestoMaquinaria { get; set; }

        [Display(Name = "Presupuesto materiales")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public double PresupuestoMateriales { get; set; }

        //Relaciones
        [JsonIgnore]

        [ForeignKey("Proyecto")]
        public int ProyectoId { get; set; }
        public Proyecto Proyectos { get; set; }
    }
}
