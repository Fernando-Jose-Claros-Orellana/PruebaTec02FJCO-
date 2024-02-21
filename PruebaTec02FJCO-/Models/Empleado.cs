using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PruebaTec02FJCO_.Models
{
    public partial class Empleado
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string? Nombre { get; set; }
        [StringLength(50)]
        public string? Apellido { get; set; }
        public byte[]? Imagen { get; set; }
        public decimal? Salario { get; set; }
        public int? DepartamentoId { get; set; }

        public virtual Departamento? Departamento { get; set; }
    }
}
