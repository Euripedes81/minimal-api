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
    public class MarcaServicoTeste
    {   
        private readonly MarcaServico? _marcaServico;  

        public MarcaServicoTeste()
        {
            _marcaServico = new MarcaServico(CriadorContexto.CriarContextoDeTeste());
        }  

        public void TestarBuscaPorId()
        {
           var marca = _marcaServico?.BuscaPorId(1);

           Assert.AreEqual(1, marca);
        }

        public void TestarIncluir()
        {
             var context = CriadorContexto.CriarContextoDeTeste();
            context.Database.ExecuteSqlRaw("TRUNCATE TABLE Veiculos");

            Marca marca = new Marca()
            {
                Id = 1,
                NomeMarca = "Fiat"
            };

            _marcaServico?.Incluir(marca);

            Assert.AreSame(marca, _marcaServico?.BuscaPorId(marca.Id));
        }

    }
}