using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PruebaTec02FJCO_.Models
{
    public partial class Departamento
    {
        public Departamento()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int Id { get; set; }
        [StringLength(50)]
        public string? Nombre { get; set; }
        [StringLength(100)]
        public string? Ubicacion { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
