using System;
using System.Collections.Generic;

namespace Proyecto_recursos_humanos.Entities
{
    public partial class Idioma
    {
        public Idioma()
        {
            UsuarioIdiomas = new HashSet<UsuarioIdioma>();
        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public long? Status { get; set; }

        public virtual ICollection<UsuarioIdioma> UsuarioIdiomas { get; set; }
    }
}
