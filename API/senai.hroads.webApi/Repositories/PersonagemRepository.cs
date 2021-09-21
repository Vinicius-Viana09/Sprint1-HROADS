using senai.hroads.webApi.Contexts;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class PersonagemRepository : IPersonagem
    {
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int IdPersonagem, Personagem personagemAtualizado)
        {
            Personagem personagemBuscado = BuscarPorId(IdPersonagem);

            if (personagemAtualizado.NomePersonagem != null)
            {
                personagemBuscado.NomePersonagem = personagemAtualizado.NomePersonagem;
            }

            ctx.Personagens.Update(personagemBuscado);

            ctx.SaveChanges();
        }

        public Personagem BuscarPorId(int IdPersonagem)
        {
            return ctx.Personagens.FirstOrDefault(e => e.IdPersonagem == IdPersonagem);
        }

        public void Cadastrar(Personagem novoPersonagem)
        {
            ctx.Personagens.Add(novoPersonagem);

            ctx.SaveChanges();
        }

        public void Deletar(int IdPersonagem)
        {
            Personagem personagemBuscado = BuscarPorId(IdPersonagem);

            ctx.Personagens.Remove(personagemBuscado);

            ctx.SaveChanges();
        }

        public List<Personagem> Listar()
        {
            return ctx.Personagens.ToList();
        }
    }
}
