using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface ITipo
    {
        List<Tipo> Listar();

        Tipo BuscarPorId(int idTipo);

        void Cadastrar(Tipo novoTipo);

        void Atualizar(int idTipo, Tipo tipoAtualizado);

        void Deletar(int idTipo);
    }
}
