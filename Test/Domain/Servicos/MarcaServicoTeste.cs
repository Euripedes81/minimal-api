using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Interfaces;
using MinimalApi.Dominio.Servicos;
using Test.Helpers;

namespace Test.Domain.Servicos
{
    [TestClass]
    public class MarcaServicoTeste
    {   
        private readonly MarcaServico _marcaServico;  

        public MarcaServicoTeste()
        {
            _marcaServico = new MarcaServico(CriadorContexto.CriarContextoDeTeste());
        }  

        [TestMethod]
        public void TestarBuscaPorId()
        {
           var marca = _marcaServico?.BuscaPorId(1);

           Assert.AreEqual(1, marca?.Id);
        }

         [TestMethod]
        public void TestarIncluir()
        {
            var context = CriadorContexto.CriarContextoDeTeste();
            context.Database.ExecuteSqlRaw("DELETE FROM  MarcaVeiculos WHERE Id=2");

            Marca marca = new Marca()
            {
                Id = 2,
                NomeMarca = "Volkswagen"
            };

            _marcaServico.Incluir(marca);

            Assert.AreSame(marca, _marcaServico.BuscaPorId(marca.Id));
        }

    }
}