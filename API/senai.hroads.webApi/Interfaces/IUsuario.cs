using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface IUsuario
    {
        List<Usuario> Listar();

        Usuario BuscarPorId(int IdUsuario);

        void Cadastrar(Usuario novoUsuario);

        void Atualizar(int IdUsuario, Usuario usuariosAtualizado);

        void Deletar(int IdUsuario);
    }
}
