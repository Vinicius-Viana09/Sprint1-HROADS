using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi.Domains
{
    public partial class Personagem
    {
        public int IdPersonagem { get; set; }
        public byte? IdClasse { get; set; }
        public string NomePersonagem { get; set; }
        public string NomeJogador { get; set; }
        public short Vida { get; set; }
        public short Mana { get; set; }
        public string DataCriacao { get; set; }
        public string DataAtualizacao { get; set; }

        public virtual Classe IdClasseNavigation { get; set; }
    }
}
