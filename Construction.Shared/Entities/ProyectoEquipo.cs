using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Construction.Shared.Entities
{
    public class ProyectoEquipo
    {
        public int Id { get; set; }

        //Relaciones

        public int ProyectoId { get; set; }

        public int EquipoId { get; set; }

        [JsonIgnore]
        public Proyecto Proyectos { get; set; }

        [JsonIgnore]
        public Equipo Equipos { get; set; }
    }
}
