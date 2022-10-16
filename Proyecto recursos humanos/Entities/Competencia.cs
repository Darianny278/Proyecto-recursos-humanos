using System;
using System.Collections.Generic;

namespace Proyecto_recursos_humanos.Entities
{
    public partial class Competencia
    {
        public Competencia()
        {
            UsuarioCompetencia = new HashSet<UsuarioCompetencium>();
        }

        public long Id { get; set; }
        public string? Description { get; set; }
        public long? Status { get; set; }

        public virtual ICollection<UsuarioCompetencium> UsuarioCompetencia { get; set; }
    }
}
