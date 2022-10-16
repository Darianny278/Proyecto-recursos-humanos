using System;
using System.Collections.Generic;

namespace Proyecto_recursos_humanos.Entities
{
    public partial class Usuario
    {
        public Usuario()
        {
            Candidatos = new HashSet<Candidato>();
            Capacitaciones = new HashSet<Capacitacione>();
            ExperienciasLaborales = new HashSet<ExperienciasLaborale>();
            UsuarioCompetencia = new HashSet<UsuarioCompetencium>();
            UsuarioIdiomas = new HashSet<UsuarioIdioma>();
        }

        public long Id { get; set; }
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public string? Password { get; set; }
        public bool? Admin { get; set; }
        public bool? Logged { get; set; }

        public virtual ICollection<Candidato> Candidatos { get; set; }
        public virtual ICollection<Capacitacione> Capacitaciones { get; set; }
        public virtual ICollection<ExperienciasLaborale> ExperienciasLaborales { get; set; }
        public virtual ICollection<UsuarioCompetencium> UsuarioCompetencia { get; set; }
        public virtual ICollection<UsuarioIdioma> UsuarioIdiomas { get; set; }
    }
}
