using senai.hroads.webApi.Contexts;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuario
    {
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int IdTipoUsuario, Tipousuario tipousuariosAtualizado)
        {
            Tipousuario tipousuarioBuscado = BuscarPorId(IdTipoUsuario);

            if (tipousuariosAtualizado.NomeTipoUsuario != null)
            {
                tipousuarioBuscado.NomeTipoUsuario = tipousuariosAtualizado.NomeTipoUsuario;
            }

            ctx.Tipousuarios.Update(tipousuarioBuscado);

            ctx.SaveChanges();
        }

        public Tipousuario BuscarPorId(int IdTipoUsuario)
        {
            return ctx.Tipousuarios.FirstOrDefault(e => e.IdTipoUsuario == IdTipoUsuario);
        }

        public void Cadastrar(Tipousuario novoTipoUsuario)
        {
            ctx.Tipousuarios.Add(novoTipoUsuario);

            ctx.SaveChanges();
        }

        public void Deletar(int IdTipoUsuario)
        {
            Tipousuario tipousuarioBuscado = BuscarPorId(IdTipoUsuario);

            ctx.Tipousuarios.Remove(tipousuarioBuscado);

            ctx.SaveChanges();
        }

        public List<Tipousuario> Listar()
        {
            return ctx.Tipousuarios.ToList();
        }
    }
}
