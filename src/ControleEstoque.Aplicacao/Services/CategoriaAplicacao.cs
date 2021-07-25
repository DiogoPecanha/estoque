using ControleEstoque.Domain.Models;
using ControleEstoque.Domain.Repositories;
using ControleEstoque.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoque.Aplicacao.Services
{
    public class CategoriaAplicacao : ICategoriaService
    {
        private readonly ICategoriaRepository categoriaRepository;

        public CategoriaAplicacao(ICategoriaRepository categoriaRepository)
        {
            this.categoriaRepository = categoriaRepository;
        }

        public async Task<Categoria> Criar(Categoria categoria)
        {
            var existeCategorias = await ObterPorTermo(categoria.Nome);

            if (existeCategorias.Count() == 1)
            {
                throw new Exception($"Já existe uma categoria cadastrada com o nome {categoria.Nome}");
            }

            return await categoriaRepository.Criar(categoria);
        }

        public async Task<Categoria> ObterPorCodigo(long codigo)
        {
            return await categoriaRepository.ObterPorId(codigo);
        }

        public async Task<IEnumerable<Categoria>> ObterPorTermo(string termo)
        {
            return await categoriaRepository.ObterPorTermo(termo);
        }

        public async Task<IEnumerable<Categoria>> ObterTodos()
        {
            return await categoriaRepository.ObterTodos();
        }
    }
}
