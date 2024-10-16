using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades
{
    [TestClass]
    public class MarcaTest
    {
        [TestMethod]

        public void TestarGetSetPropriedades()
        {
            // Arrange
            Marca marca = new Marca();

            //Act
            marca.Id = 1;
            marca.NomeMarca = "Fiat";

            //Assert
            Assert.AreEqual(1, marca.Id);
            Assert.AreEqual("Fiat", marca.NomeMarca);
        }
        
    }
}