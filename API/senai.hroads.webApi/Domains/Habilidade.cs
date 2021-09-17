using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi.Domains
{
    public partial class Habilidade
    {
        public Habilidade()
        {
            Habilidadeclasses = new HashSet<Habilidadeclasse>();
        }

        public byte IdHabilidade { get; set; }
        public byte? IdTipo { get; set; }
        public string NomeHabilidade { get; set; }

        public virtual Tipo IdTipoNavigation { get; set; }
        public virtual ICollection<Habilidadeclasse> Habilidadeclasses { get; set; }
    }
}
