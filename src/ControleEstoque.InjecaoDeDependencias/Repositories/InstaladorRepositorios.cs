using ControleEstoque.Database.Context;
using ControleEstoque.Database.Repository;
using ControleEstoque.Domain.Repositories;
using SimpleInjector;

namespace ControleEstoque.IoC.Repositories
{
    public class InstaladorRepositorios
    {
        public static void RegisterServices(Container container)
        {
            container.Register<AppDbContext>(Lifestyle.Scoped);

            container.Register<ICategoriaRepository, CategoriaRepository>(Lifestyle.Scoped);
        }
    }
}
