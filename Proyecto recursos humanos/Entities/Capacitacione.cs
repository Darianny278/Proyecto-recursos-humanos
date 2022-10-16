using System;
using System.Collections.Generic;
using Proyecto_recursos_humanos.Entities;

namespace Proyecto_recursos_humanos
{
    public partial class Capacitacione
    {
        public long Id { get; set; }
        public string? Description { get; set; }
        public string? Nivel { get; set; }
        public string? FechaInicio { get; set; }
        public string? FechaFin { get; set; }
        public string? Institucion { get; set; }
        public long? UsuarioId { get; set; }

        public virtual Usuario? Usuario { get; set; }
    }
}
