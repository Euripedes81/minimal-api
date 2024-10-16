using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinimalApi.Dominio.Entidades;

namespace Test.Mocks
{
    public class MarcaServicoMock
    {
        private List<Marca> marcas = new List<Marca>() 
        {
            new Marca { Id = 1, NomeMarca = "Fiat" },
            new Marca { Id = 2, NomeMarca = "Volkswagen" }
        };

        public Marca? BuscaPorId(int id)
        {
            return marcas.Find(m => m.Id == id);
        }

        public void Incluir(Marca marca)
        {
            marcas.Add(marca);
        }
    }
}