using System.Collections.Generic;
using System;
using CodeFirst.WebApi.Models.Entities;

namespace CodeFirst.WebApi.Infra.Data.LocalDb.Repositories
{
    public interface IVendaRepository : IDisposable
    {
        void Adicionar(Venda venda);
        ICollection<Venda> ObterTodos();
        Venda ObterPorId(int vendaId);
        ICollection<Venda> ObterPorProdutoId(int produtoId);
        ICollection<Venda> ObterPorProdutoIdProcedure(int produtoId);
    }
}