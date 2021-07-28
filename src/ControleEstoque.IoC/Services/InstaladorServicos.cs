using ControleEstoque.Aplicacao.Services;
using ControleEstoque.Application.Services;
using ControleEstoque.Domain.Services;
using SimpleInjector;

namespace ControleEstoque.IoC.Services
{
    public class InstaladorServicos
    {
        public static void RegisterServices(Container container)
        {
            container.Register<ICategoriaService, CategoriaAplicacao>();
            container.Register<IProdutoService, ProdutoAplicacao>();
        }
    }
}
