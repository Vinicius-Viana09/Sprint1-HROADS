using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi.Domains
{
    public partial class Classe
    {
        public Classe()
        {
            Habilidadeclasses = new HashSet<Habilidadeclasse>();
            Personagens = new HashSet<Personagem>();
        }

        public byte IdClasse { get; set; }
        public string NomeClasse { get; set; }

        public virtual ICollection<Habilidadeclasse> Habilidadeclasses { get; set; }
        public virtual ICollection<Personagem> Personagens { get; set; }
    }
}
