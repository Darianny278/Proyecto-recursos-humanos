using System;
using System.Collections.Generic;

namespace Proyecto_recursos_humanos.Entities
{
    public partial class Puesto
    {
        public Puesto()
        {
            Candidatos = new HashSet<Candidato>();
        }

        public long Id { get; set; }
        public string? Nombre { get; set; }
        public string? NivelRiesgo { get; set; }
        public long? SalarioMinimo { get; set; }
        public long? SalarioMaximo { get; set; }
        public long? Status { get; set; }

        public virtual ICollection<Candidato> Candidatos { get; set; }
    }
}
