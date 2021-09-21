using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface IHabilidadeClasse
    {
        List<Habilidadeclasse> Listar();

        Habilidadeclasse BuscarPorId(int idHabilidadeclasses);

        void Cadastrar(Habilidadeclasse novaHabilidadeclasses);

        void Atualizar(int idHabilidadeclasse, Habilidadeclasse habilidadeclassesAtualizado);

        void Deletar(int idHabilidadeclasses);
    }
}
