using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction.Shared.Entities
{
    public class ProyectoEquipo
    {
        public int Id { get; set; }

        //Relaciones
        public Proyecto Proyectos { get; set; }
        public Equipo Equipos { get; set; }
    }
}
