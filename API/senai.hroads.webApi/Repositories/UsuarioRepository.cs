using senai.hroads.webApi.Contexts;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class UsuarioRepository : IUsuario
    {
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int IdUsuario, Usuario usuariosAtualizado)
        {
            Usuario usuarioBuscado = BuscarPorId(IdUsuario);

            if (usuariosAtualizado.NomeUsuario != null)
            {
                usuarioBuscado.NomeUsuario = usuariosAtualizado.NomeUsuario;
            }

            ctx.Usuarios.Update(usuarioBuscado);

            ctx.SaveChanges();
        }

        public Usuario BuscarPorId(int IdUsuario)
        {
            return ctx.Usuarios.FirstOrDefault(e => e.IdUsuario == IdUsuario);
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);

            ctx.SaveChanges();
        }

        public void Deletar(int IdUsuario)
        {
            Usuario usuarioBuscado = BuscarPorId(IdUsuario);

            ctx.Usuarios.Remove(usuarioBuscado);

            ctx.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return ctx.Usuarios.ToList();
        }
    }
}
