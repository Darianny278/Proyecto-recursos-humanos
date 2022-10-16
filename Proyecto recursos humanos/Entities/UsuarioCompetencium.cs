using System;
using System.Collections.Generic;

namespace Proyecto_recursos_humanos.Entities
{
    public partial class UsuarioCompetencium
    {
        public long Id { get; set; }
        public long? UsuarioId { get; set; }
        public long? CompetenciaId { get; set; }

        public virtual Competencia? Competencia { get; set; }
        public virtual Usuario? Usuario { get; set; }
    }
}
