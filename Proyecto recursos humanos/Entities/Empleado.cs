using System;
using System.Collections.Generic;

namespace Proyecto_recursos_humanos.Entities
{
    public partial class Empleado
    {
        public long Id { get; set; }
        public string? Nombre { get; set; }
        public long? Cedula { get; set; }
        public string? Puesto { get; set; }
        public long? Salario { get; set; }
        public string? Departamento { get; set; }
        public string? FechaInicio { get; set; }
        public bool? Status { get; set; }
    }
}
