using ControleEstoque.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleEstoque.Domain.Services
{
    public interface IProdutoService
    {
        /// <summary>
        /// Atualiza a quantidade de itens um determinado produto
        /// </summary>
        /// <param name="codigoProduto"></param>
        /// <param name="quantidade"></param>        
        Task AtualizarEstoque(long codigoProduto, decimal quantidade);

        /// <summary>
        /// Cria um novo produto ou atualiza um existente
        /// </summary>
        /// <param name="produto">Produto a ser criado</param>
        /// <returns>Produto criado</returns>
        Task<Produto> Salvar(Produto produto);

        /// <summary>
        /// Obtêm os produtos cadastrados
        /// </summary>
        /// <returns>Lista com os produtos cadastrados</returns>
        Task<IEnumerable<Produto>> ObterTodos();

        /// <summary>
        /// Obtem um produto pelo seu código
        /// </summary>
        /// <param name="codigo">Codigo da produto para consulta</param>
        /// <returns>produto</returns>
        Task<Produto> ObterPorCodigo(long codigo);

        /// <summary>
        /// Obtem os dados de produtos paginados
        /// </summary>
        /// <param name="ordem">qual campo para ordenar</param>
        /// <param name="termo">termo de consulta do nome do produto</param>
        /// <returns>Lista de produtos ordenados/filtrados</returns>
        Task<IEnumerable<Produto>> ObterDadosPaginados(string ordem, string termo);
    }
}

