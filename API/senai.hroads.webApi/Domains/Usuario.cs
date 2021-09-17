using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi.Domains
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public byte? IdTipoUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string EmailUsuario { get; set; }

        public string SenhaUsuario { get; set; }

        public virtual Tipousuario IdTipoUsuarioNavigation { get; set; }
    }
}
