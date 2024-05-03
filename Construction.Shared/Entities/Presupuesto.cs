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
        [DisplayFormat(DataFormatString ="{0:N2}")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public decimal PresupuestoManoObra { get; set; }

        [Display(Name = "Presupuesto maquinaria")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public decimal PresupuestoMaquinaria { get; set; }

        [Display(Name = "Presupuesto materiales")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public decimal PresupuestoMateriales { get; set; }

        //Relaciones
        

        

        [JsonIgnore]
        public int ProyectoId { get; set; }

        [JsonIgnore]
        public Proyecto Proyectos { get; set; }
    }
}
