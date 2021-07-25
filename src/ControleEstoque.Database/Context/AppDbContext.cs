using ControleEstoque.Database.EntityConfig;
using ControleEstoque.Domain.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ControleEstoque.Database.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("EstoqueDatabase")
        {
            Database.Initialize(false);
            Database.CreateIfNotExists();
        }        

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new ProdutoEntityConfig());
            modelBuilder.Configurations.Add(new CategoriaEntityConfig());
            base.OnModelCreating(modelBuilder);
        }

    }
}
