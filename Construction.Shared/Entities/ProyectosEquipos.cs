using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction.Shared.Entities
{
    public class ProyectosEquipos
    {
        public int IdProyecto { get; set; }
        public int IdEquipo { get; set; }

        //Relaciones

        public Proyecto Proyectos { get; set; }
        public Equipo Equipos { get; set; }
    }
}
