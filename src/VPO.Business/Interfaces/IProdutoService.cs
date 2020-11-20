using System;
using System.Threading.Tasks;
using VPO.Business.Models;

namespace VPO.Business.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto fornecedor);
        Task Atualizar(Produto fornecedor);
        Task Remover(Guid id);
    }
}