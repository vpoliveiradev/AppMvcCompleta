using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VPO.Business.Interfaces;
using VPO.Business.Models;
using VPO.Data.Context;

namespace VPO.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context) : base(context) { }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(e => e.FornecedorId == fornecedorId);
        }
    }
}