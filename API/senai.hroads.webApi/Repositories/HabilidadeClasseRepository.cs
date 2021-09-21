using senai.hroads.webApi.Contexts;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class HabilidadeClasseRepository : IHabilidadeClasse
    {
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int idHabilidadeclasse, Habilidadeclasse habilidadeclassesAtualizada)
        {
            Habilidadeclasse habilidadeclasseBuscada = BuscarPorId(idHabilidadeclasse);

            if (habilidadeclassesAtualizada.IdHabilidade != null)
            {
                habilidadeclasseBuscada.IdHabilidade = habilidadeclassesAtualizada.IdHabilidade;
            }

            ctx.Habilidadeclasses.Update(habilidadeclasseBuscada);

            ctx.SaveChanges();
        }

        public Habilidadeclasse BuscarPorId(int idHabilidadeclasses)
        {
            return ctx.Habilidadeclasses.FirstOrDefault(e => e.IdHabilidadeClasse == idHabilidadeclasses);
        }

        public void Cadastrar(Habilidadeclasse novaHabilidadeclasses)
        {
            ctx.Habilidadeclasses.Add(novaHabilidadeclasses);

            ctx.SaveChanges();
        }

        public void Deletar(int idHabilidadeclasses)
        {
            Habilidadeclasse habilidadeclasseBuscada = BuscarPorId(idHabilidadeclasses);

            ctx.Habilidadeclasses.Remove(habilidadeclasseBuscada);

            ctx.SaveChanges();
        }

        public List<Habilidadeclasse> Listar()
        {
            return ctx.Habilidadeclasses.ToList();
        }
    }
}
