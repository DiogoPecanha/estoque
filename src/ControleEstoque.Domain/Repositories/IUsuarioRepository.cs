using ControleEstoque.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleEstoque.Domain.Repositories
{
    public interface IUsuarioRepository
    {
        /// <summary>
        /// Obtêm usuário pelo id informado
        /// </summary>
        /// <param name="id">id usuário</param>
        /// <returns>Usuário</returns>
        Task<Usuario> ObterPorId(string id);

        /// <summary>
        /// Obtêm todos os usuários cadastrados
        /// </summary>
        /// <returns>Usuários</returns>
        Task<IEnumerable<Usuario>> ObterTodos();
    }
}
