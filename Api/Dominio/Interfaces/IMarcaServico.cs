using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinimalApi.Dominio.Entidades;

namespace MinimalApi.Dominio.Interfaces
{
    public interface IMarcaServico
    {
        List<Marca> Todos(int? pagina = 1, string? nome = null);
        Marca? BuscaPorId(int id);
        void Incluir(Marca marca);
        void Atualizar(Marca marca);
        void Apagar(Marca marca);
    }
}