using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Interfaces;
using MinimalApi.Infraestrutura.Db;

namespace MinimalApi.Dominio.Servicos
{
    public class MarcaServico : IMarcaServico

    {
        private readonly DbContexto _contexto;
        public MarcaServico(DbContexto contexto)
        {
            _contexto = contexto;
        }

        public void Apagar(Marca marca)
        {
            _contexto.MarcaVeiculos.Remove(marca);
            _contexto.SaveChanges();
        }

        public void Atualizar(Marca marca)
        {
            _contexto.MarcaVeiculos.Update(marca);
            _contexto.SaveChanges();
        }

        public Marca? BuscaPorId(int id)
        {
            return _contexto.MarcaVeiculos.FirstOrDefault(v => v.Id == id);
        }

        public void Incluir(Marca marca)
        {
            _contexto.MarcaVeiculos.Add(marca);
            _contexto.SaveChanges();
        }

        public List<Marca> Todos(int? pagina = 1, string? nome = null)
        {
            var query = _contexto.MarcaVeiculos.AsQueryable();
            if (!string.IsNullOrEmpty(nome))
            {
                query = query.Where(m => EF.Functions.Like(m.NomeMarca.ToLower(), $"%{nome}%"));
            }

            int itensPorPagina = 10;

            if (pagina != null)
                query = query.Skip(((int)pagina - 1) * itensPorPagina).Take(itensPorPagina);

            return query.ToList();
        }

    }
}