using ControleEstoque.Database.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.Database
{
    public class EstoqueContext : DbContext
    {
        public EstoqueContext() : base("EstoqueContext")
        {

        }

        public DbSet<ProdutoEntity> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

    }
}
