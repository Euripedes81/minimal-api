using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MinimalApi.Dominio.Entidades;
using MinimalApi.DTOs;
using Test.Helpers;

namespace Test.Requests
{
    [TestClass]
    public class VeiculoRequestTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            Setup.ClassInit(testContext);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Setup.ClassCleanup();
        }

        [TestMethod]
        public async Task TestarPostSemAutenticacao()
        {
            // Arrange
            VeiculoDTO veiculoDTO = new VeiculoDTO
            {
                Nome = "Palio",
                Marca = "Fiat",
                Ano = 2009
            };

            var content = new StringContent(JsonSerializer.Serialize(veiculoDTO), Encoding.UTF8, "Application/json");

            // Act
            var response = await Setup.client.PostAsync("/veiculos", content);

            // Assert
            Assert.AreEqual(HttpStatusCode.Unauthorized, response.StatusCode);           
        }
    }
}