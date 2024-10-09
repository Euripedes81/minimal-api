using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Interfaces;
using MinimalApi.Dominio.Servicos;
using Test.Helpers;
using Test.Mocks;

namespace Test.Domain.Servicos
{
    [TestClass]

    public class VeiculoServicoTeste
    {  
        private readonly VeiculoServico _veiculoServico;
        public VeiculoServicoTeste()
        {
            _veiculoServico = new VeiculoServico(CriadorContexto.CriarContextoDeTeste()); 
        }

        [TestMethod]        
        public void TestandoBuscaPorId()
        {              

            //Act
            var veiculo = _veiculoServico?.BuscaPorId(1);

            //Assert
            Assert.AreEqual(1, veiculo?.Id);
        }

        [TestMethod]
        public void TestandoSalvarVeiculo()
        {
            //Arrange
            var context = CriadorContexto.CriarContextoDeTeste();
            context.Database.ExecuteSqlRaw("TRUNCATE TABLE Veiculos");
            var veiculo = new Veiculo()
                {
                    Id = 1,
                    Nome = "Gol",
                    Marca = "Volkswagen",
                    Ano = 2001
                };
            //Act
            _veiculoServico.Incluir(veiculo);            
          
            //Assert
            Assert.AreSame(veiculo, _veiculoServico.BuscaPorId(veiculo.Id));
        }       
    }
}