using System;
using System.Collections.Generic;

namespace PruebaTec02FJCO_.Models
{
    public partial class Departamento
    {
        public Departamento()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Ubicacion { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
