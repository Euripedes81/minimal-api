using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinimalApi.Dominio.Entidades;

namespace mininal_api.Dominio.ModelViews
{
    public class VeiculoModelView
    {
         public int Id { get;set; } = default!;
         public string Nome { get;set; } = default!;        
         public int Ano { get; set; } = default!;
         public Marca MarcaVeiculo { get; set; } = default!;       

    }
}