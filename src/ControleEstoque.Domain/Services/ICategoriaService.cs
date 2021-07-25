using ControleEstoque.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
