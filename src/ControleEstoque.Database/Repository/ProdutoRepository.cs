using ControleEstoque.Database.Context;
using ControleEstoque.Domain.Models;
using ControleEstoque.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;

namespace ControleEstoque.Database.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext db;

        public ProdutoRepository()
        {
            db = new AppDbContext();
        }

        public void Dispose()
        {
            db.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task<Produto> Criar(Produto produto)
        {
            db.Produtos.Add(produto);
            await db.SaveChangesAsync();
            return produto;
        }

        public async Task<IEnumerable<Produto>> ObterDadosPaginados(string ordem, string termo)
        {
            var produtos = await db.Produtos.ToArrayAsync();

            if (!String.IsNullOrEmpty(termo))
            {
                produtos = produtos.Where(s => s.Nome.Contains(termo)).ToArray();
            }
            switch (ordem)
            {
                case "Codigo":
                    produtos = produtos.OrderByDescending(s => s.Codigo).ToArray();
                    break;
                case "Categoria":
                    produtos = produtos.OrderBy(s => s.Categoria).ToArray();
                    break;
                case "Nome":
                    produtos = produtos.OrderByDescending(s => s.Nome).ToArray();
                    break;
                case "Descricao":
                    produtos = produtos.OrderByDescending(s => s.Descricao).ToArray();
                    break;
                case "UnidadeMedida":
                    produtos = produtos.OrderByDescending(s => s.UnidadeMedida).ToArray();
                    break;
                default:  
                    produtos = produtos.OrderBy(s => s.Codigo).ToArray();
                    break;
            }

            return produtos;
        }

        public async Task<Produto> ObterPorCodigo(long codigo)
        {
            return await db.Produtos.FindAsync(codigo);
        }

        public async Task<IEnumerable<Produto>> ObterPorTermo(string termo)
        {
            return await db.Produtos.Where(c => c.Nome.Contains(termo)).ToListAsync();
        }

        public async Task<IEnumerable<Produto>> ObterTodos()
        {
            return await db.Produtos.ToArrayAsync();
        }

        public async Task<Produto> Salvar(Produto produto)
        {
            var produtoParaAtualizar = await db.Produtos.SingleOrDefaultAsync(p => p.Codigo == produto.Codigo);
            produtoParaAtualizar.Categoria = produto.Categoria;
            produtoParaAtualizar.Descricao = produto.Descricao;
            produtoParaAtualizar.Nome = produto.Nome;
            produtoParaAtualizar.UnidadeMedida = produto.UnidadeMedida;
            produtoParaAtualizar.Quantidade = produto.Quantidade;
            await db.SaveChangesAsync();

            return produtoParaAtualizar;

        }
    }
}
