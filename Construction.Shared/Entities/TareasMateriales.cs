using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction.Shared.Entities
{
    public class TareasMateriales
    {
        public int IdTarea { get; set; }
        public int IdMaterial { get; set; }

        //Relaciones

        public Material Materiales { get; set; }
        public Tarea Tareas { get; set; }
    }
}
