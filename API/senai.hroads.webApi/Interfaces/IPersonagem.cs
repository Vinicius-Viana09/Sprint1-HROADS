using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface IPersonagem
    {
        List<Personagem> Listar();

        Personagem BuscarPorId(int IdPersonagem);

        void Cadastrar(Personagem novoPersonagem);

        void Atualizar(int IdPersonagem, Personagem personagemAtualizado);

        void Deletar(int IdPersonagem);
    }
}
