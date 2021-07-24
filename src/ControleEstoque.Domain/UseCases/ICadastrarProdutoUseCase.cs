using ControleEstoque.Domain.Models;
using System.Threading.Tasks;

namespace ControleEstoque.Domain.UseCases
{
    public interface ICadastrarProdutoUseCase
    {
        /// <summary>
        /// Cadastra um novo produto
        /// </summary>
        /// <param name="produto"></param>
        /// <returns></returns>
        Task Execute(Produto produto);
    }
}
