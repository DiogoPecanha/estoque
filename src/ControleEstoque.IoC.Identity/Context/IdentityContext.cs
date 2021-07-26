using ControleEstoque.IoC.Identity.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace ControleEstoque.IoC.Identity.Context
{
    public class IdentityContext : IdentityDbContext<ApplicationUser>, IDisposable
    {
        public IdentityContext()
            : base("EstoqueDatabase", throwIfV1Schema: false)
        {
        }

        public static IdentityContext Create()
        {
            return new IdentityContext();
        }
    }
}
