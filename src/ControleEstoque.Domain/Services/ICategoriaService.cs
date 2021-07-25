using ControleEstoque.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleEstoque.Domain.Services
{
    public interface ICategoriaService
    {
        /// <summary>
        /// Obtem todas as categorias cadastradas
        /// </summary>
        /// <returns>lista de categorias</returns>
        Task<IEnumerable<Categoria>> ObterTodos();


        /// <summary>
        /// Cria uma nova categoria
        /// </summary>
        /// <param name="categoria">categoria a ser criada</param>
        /// <returns>retorna a categoria salva</returns>
        Task<Categoria> Criar(Categoria categoria);

        /// <summary>
        /// Obtem uma lista de categorias que possuem o termo pesquisado
        /// </summary>
        /// <param name="termo">palavra chave contida no nome da categoria</param>
        /// <returns>Lista de categorias com o filtro informado</returns>
        Task<IEnumerable<Categoria>> ObterPorTermo(string termo);

        /// <summary>
        /// Obtem uma categoria pelo seu id
        /// </summary>
        /// <param name="codigo">Codigo da categoria para consulta</param>
        /// <returns>categoria</returns>
        Task<Categoria> ObterPorCodigo(long codigo);
    }
}
