using ControleEstoque.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleEstoque.Domain.Repositories
{
    public interface ICategoriaRepository : IDisposable
    {
        /// <summary>
        /// Obtem uma categoria pelo seu id
        /// </summary>
        /// <param name="codigo">Codigo da categoria para consulta</param>
        /// <returns>categoria</returns>
        Task<Categoria> ObterPorId(long codigo);
        
        /// <summary>
        /// Obtem todas as categorias cadastradas
        /// </summary>
        /// <returns>lista de categorias</returns>
        Task<IEnumerable<Categoria>> ObterTodos();

        /// <summary>
        /// Obtem uma lista de categorias que possuem o termo pesquisado
        /// </summary>
        /// <param name="termo">palavra chave contida no nome da categoria</param>
        /// <returns>Lista de categorias com o filtro informado</returns>
        Task<IEnumerable<Categoria>> ObterPorTermo(string termo);


        /// <summary>
        /// Salva uma nova categoria
        /// </summary>
        /// <param name="categoria">objeto categoria a ser salva</param>
        /// <returns>Categoria salva com o identificador</returns>
        Task<Categoria> Criar(Categoria categoria);

    }
}
