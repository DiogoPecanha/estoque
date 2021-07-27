using ControleEstoque.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleEstoque.Domain.Repositories
{
    public interface IProdutoRepository : IDisposable
    {
        /// <summary>
        /// Obtem um produto pelo seu código
        /// </summary>
        /// <param name="codigo">Codigo da produto para consulta</param>
        /// <returns>produto</returns>
        Task<Produto> ObterPorCodigo(long codigo);

        /// <summary>
        /// Obtem todas as produtos cadastradas
        /// </summary>
        /// <returns>lista de produtos</returns>
        Task<IEnumerable<Produto>> ObterTodos();

        /// <summary>
        /// Obtem uma lista de produtos que possuem o termo pesquisado
        /// </summary>
        /// <param name="termo">palavra chave contida no nome da produto</param>
        /// <returns>Lista de produtos com o filtro informado</returns>
        Task<IEnumerable<Produto>> ObterPorTermo(string termo);

        /// <summary>
        /// Obtem os dados de produtos paginados
        /// </summary>
        /// <param name="ordem">qual campo para ordenar</param>
        /// <param name="termo">termo de consulta do nome do produto</param>
        /// <returns>Lista de produtos ordenados/filtrados</returns>
        Task<IEnumerable<Produto>> ObterDadosPaginados(string ordem, string termo);

        /// <summary>
        /// Salva uma nova produto
        /// </summary>
        /// <param name="produto">objeto produto a ser salva</param>
        /// <returns>Produto salva com o identificador</returns>
        Task<Produto> Criar(Produto produto);

        /// <summary>
        /// Atualiza um produto
        /// </summary>
        /// <param name="produto">objeto produto a ser salva</param>
        /// <returns>Produto salva com o identificador</returns>
        Task<Produto> Salvar(Produto produto);

    }
}
