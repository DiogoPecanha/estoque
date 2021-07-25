using ControleEstoque.Aplicacao.Services;
using ControleEstoque.Domain.Services;
using SimpleInjector;

namespace ControleEstoque.InjecaoDeDependencias.Services
{
    public class InstaladorServicos
    {
        public static void RegisterServices(Container container)
        {
            container.Register<ICategoriaService, CategoriaAplicacao>();
        }
    }
}
