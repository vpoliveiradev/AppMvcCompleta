using System;
using System.Threading.Tasks;
using VPO.Business.Interfaces;
using VPO.Business.Models;
using VPO.Business.Models.Validations;

namespace VPO.Business.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository,
                              INotifier notifier) : base(notifier)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Adicionar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            await _produtoRepository.Add(produto);
        }

        public async Task Atualizar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            await _produtoRepository.Update(produto);
        }

        public async Task Remover(Guid id)
        {
            await _produtoRepository.Remove(id);
        }

        public void Dispose()
        {
            _produtoRepository?.Dispose();
        }
    }
}