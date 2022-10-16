using System;
using System.Collections.Generic;

namespace Proyecto_recursos_humanos.Entities
{
    public partial class ExperienciasLaborale
    {
        public long Id { get; set; }
        public string? Empresa { get; set; }
        public string? Puesto { get; set; }
        public string? Inicio { get; set; }
        public string? Hasta { get; set; }
        public string? Salario { get; set; }
        public long? UsuarioId { get; set; }

        public virtual Usuario? Usuario { get; set; }
    }
}
