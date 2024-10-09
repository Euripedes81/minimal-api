using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades
{
    [TestClass]
    public class VeiculoTest
    {
        [TestMethod]

        public void TestarGetSetPropriedades()
        {
            //Arrange
            Veiculo veiculo = new Veiculo();

            //Act
            veiculo.Id = 1;
            veiculo.Nome = "Fusca";
            veiculo.Marca = "Volkswagen";
            veiculo.Ano = 1970;

            //Assert
            Assert.AreEqual(1, veiculo.Id);
            Assert.AreEqual("Fusca", veiculo.Nome);
            Assert.AreEqual("Volkswagen", veiculo.Marca);
            Assert.AreEqual(1970, veiculo.Ano);

        }
    }
}