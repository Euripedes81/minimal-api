using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Interfaces;

namespace Test.Mocks
{
    public class VeiculoServicoMock : IVeiculoServico
    {     
        private List<Veiculo> _veiculos = new List<Veiculo> 
        {
            new Veiculo { Id = 1, Nome = "Fusca", Marca = "Volkswagen" , Ano = 1970},
            new Veiculo { Id = 2, Nome = "Opalla", Marca = "Chevrolett", Ano = 1974}
        };
        public void Apagar(Veiculo veiculo)
        {
            _veiculos.Remove(veiculo);
        }

        public void Atualizar(Veiculo veiculo)
        {
           for (int i = 0; i < _veiculos.Count; i++)
           {
                if (_veiculos[i].Id == veiculo.Id)
                {
                    _veiculos[i] = veiculo;
                }
           }
        }

        public Veiculo? BuscaPorId(int id)
        {
           return _veiculos.Find(v => v.Id == id);          
        }

        public void Incluir(Veiculo veiculo)
        {
            _veiculos.Add(veiculo);
        }

        public List<Veiculo> Todos(int? pagina = 1, string? nome = null, string? marca = null)
        {
            return _veiculos;
        }
    }
}