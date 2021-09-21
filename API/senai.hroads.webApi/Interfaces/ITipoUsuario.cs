using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface ITipoUsuario
    {
        List<Tipousuario> Listar();

        Tipousuario BuscarPorId(int IdTipoUsuario);

        void Cadastrar(Tipousuario novoTipoUsuario);

        void Atualizar(int IdTipoUsuario, Tipousuario tipousuariosAtualizado);

        void Deletar(int IdTipoUsuario);
    }
}
