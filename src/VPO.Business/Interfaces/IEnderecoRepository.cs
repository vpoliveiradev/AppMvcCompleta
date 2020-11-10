using System;
using System.Threading.Tasks;
using VPO.Business.Models;

namespace VPO.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
         Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}