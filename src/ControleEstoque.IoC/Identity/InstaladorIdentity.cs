using ControleEstoque.Database.Repository;
using ControleEstoque.Domain.Repositories;
using ControleEstoque.IoC.Identity.Config;
using ControleEstoque.IoC.Identity.Context;
using ControleEstoque.IoC.Identity.Model;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using SimpleInjector;
using System.Web;

namespace ControleEstoque.IoC.Repositories
{
    public class InstaladorIdentity
    {
        public static void RegisterServices(Container container)
        {
            container.Register<IdentityContext>(Lifestyle.Scoped);
            container.Register<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new IdentityContext()), Lifestyle.Scoped);
            container.Register<IRoleStore<IdentityRole, string>>(() => new RoleStore<IdentityRole>(), Lifestyle.Scoped);
            container.Register<ApplicationRoleManager>(Lifestyle.Scoped);
            container.Register<ApplicationUserManager>(Lifestyle.Scoped);
            container.Register<ApplicationSignInManager>(Lifestyle.Scoped);
            
            container.Register(() =>
                                container.IsVerifying
                                    ? new OwinContext().Authentication
                                    : HttpContext.Current.GetOwinContext().Authentication,
                                Lifestyle.Scoped);

            container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Scoped);
        }
    }
}
