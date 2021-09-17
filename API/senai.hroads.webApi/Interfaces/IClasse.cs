using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface IClasse
    {
        List<Classe> Listar();

        Classe BuscarPorId(int idClasse);

        void Cadastrar(Classe novaClasse);

        void Atualizar(int idClasse, Classe classeAtualizada);

        void Deletar(int idClasse);

    }
}
