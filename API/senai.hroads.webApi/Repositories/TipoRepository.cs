using senai.hroads.webApi.Contexts;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class TipoRepository : ITipo
    {
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int idTipo, Tipo tipoAtualizado)
        {
            Tipo tipoBuscado = BuscarPorId(idTipo);

            if (tipoAtualizado.NomeTipo != null)
            {
                tipoBuscado.NomeTipo = tipoAtualizado.NomeTipo;
            }

            ctx.Tipos.Update(tipoBuscado);

            ctx.SaveChanges();
        }

        public Tipo BuscarPorId(int idTipo)
        {
            return ctx.Tipos.FirstOrDefault(e => e.IdTipo == idTipo);
        }

        public void Cadastrar(Tipo novoTipo)
        {
            ctx.Tipos.Add(novoTipo);

            ctx.SaveChanges();
        }

        public void Deletar(int idTipo)
        {
            Tipo tipoBuscado = BuscarPorId(idTipo);

            ctx.Tipos.Remove(tipoBuscado);

            ctx.SaveChanges();
        }

        public List<Tipo> Listar()
        {
            return ctx.Tipos.ToList();
        }
    }
}
