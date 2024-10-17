using Microsoft.EntityFrameworkCore;
using MinimalApi.Dominio.Entidades;
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
                    MarcaVeiculosId = 1,
                    Ano = 2001
                };
            //Act
            _veiculoServico.Incluir(veiculo);         
            //Assert
            Assert.AreSame(veiculo, _veiculoServico.BuscaPorId(veiculo.Id));
        }

        [TestMethod]
        public void TestarApagarVeiculo()
        {
            //Arrange
            Veiculo veiculo = new Veiculo()
            {
                Id = 2,
                Nome = "Opalla",
                MarcaVeiculosId = 1,
                Ano = 1974
            };

            VeiculoServicoMock veiculoServicoMock = new VeiculoServicoMock();

            //Act
            veiculoServicoMock.Apagar(veiculo);

            //Assert
            Assert.IsNotNull(veiculo);
        }       
    }
}