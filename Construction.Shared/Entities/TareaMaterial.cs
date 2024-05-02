using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Construction.Shared.Entities
{
    public class TareaMaterial
    {
        public int Id { get; set; }
      
        public int MaterialId { get; set; }

        public int TareaId { get; set; }

        [JsonIgnore]
        public Material Materiales { get; set; }

        [JsonIgnore]
        public Tarea Tareas { get; set; }
    }
}
