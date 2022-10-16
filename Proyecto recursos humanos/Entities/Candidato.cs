using System;
using System.Collections.Generic;

namespace Proyecto_recursos_humanos.Entities
{
    public partial class Candidato
    {
        public long Id { get; set; }
        public long? Cedula { get; set; }
        public long? UsuarioId { get; set; }
        public long? PuestoId { get; set; }
        public string? Departamento { get; set; }
        public long? Salario { get; set; }
        public string? RecomendadoPor { get; set; }

        public bool? Reclutado { get; set; }

        public virtual Puesto? Puesto { get; set; }
        public virtual Usuario? Usuario { get; set; }
    }
}
