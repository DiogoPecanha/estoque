using ControleEstoque.Domain.Models;
using ControleEstoque.Domain.Repositories;
using ControleEstoque.Domain.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleEstoque.Aplicacao.Services
{
    public class ProdutoAplicacao : IProdutoService
    {
        private readonly IProdutoRepository produtoRepository;

        public ProdutoAplicacao(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        public async Task AtualizarEstoque(long codigoProduto, decimal quantidade)
        {
            var produto = await ObterPorCodigo(codigoProduto);
            if (produto == null)
            {
                throw new Exception("Produto não encontrado");
            }
            produto.Quantidade += quantidade;
            if (produto.Quantidade < 0)
            {
                throw new Exception("Quantidade de itens do produto não pode ser menor do 0");
            }
            await produtoRepository.Salvar(produto);
        }

        public async Task<Produto> Salvar(Produto produto)
        {
            var produtoExistente = await ObterPorCodigo(produto.Codigo);
            if (produtoExistente == null)
            {
                return await produtoRepository.Criar(produto);
            } 
            else
            {
                return await produtoRepository.Salvar(produto);
            }
        }

        public async Task<IEnumerable<Produto>> ObterDadosPaginados(string ordem, string termo)
        {
            return await produtoRepository.ObterDadosPaginados(ordem, termo);
        }

        public async Task<Produto> ObterPorCodigo(long codigo)
        {
            return await produtoRepository.ObterPorCodigo(codigo);
        }

        public async Task<IEnumerable<Produto>> ObterTodos()
        {
            return await produtoRepository.ObterTodos();
        }
    }
}
