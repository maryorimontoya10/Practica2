using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
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
        public Proyecto Proyectos { get; set; }
    }
}
