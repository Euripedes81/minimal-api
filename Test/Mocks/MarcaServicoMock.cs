using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Interfaces;

namespace Test.Mocks
{
    public class MarcaServicoMock :IMarcaServico
    {
        private List<Marca> marcas = new List<Marca>() 
        {
            new Marca { Id = 1, NomeMarca = "Fiat" },
            new Marca { Id = 2, NomeMarca = "Volkswagen" }
        };

        public void Apagar(Marca marca)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Marca marca)
        {
            throw new NotImplementedException();
        }

        public Marca? BuscaPorId(int id)
        {
            return marcas.Find(m => m.Id == id);
        }

        public void Incluir(Marca marca)
        {
            marcas.Add(marca);
        }

        public List<Marca> Todos(int? pagina = 1, string? nome = null)
        {
            throw new NotImplementedException();
        }
    }
}