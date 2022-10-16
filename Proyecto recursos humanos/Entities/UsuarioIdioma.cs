using System;
using System.Collections.Generic;

namespace Proyecto_recursos_humanos.Entities
{
    public partial class UsuarioIdioma
    {
        public long Id { get; set; }
        public long? UsuarioId { get; set; }
        public long? IdiomaId { get; set; }

        public virtual Idioma? Idioma { get; set; }
        public virtual Usuario? Usuario { get; set; }
    }
}
