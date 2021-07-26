using ControleEstoque.Database.EntityConfig;
using ControleEstoque.Domain.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ControleEstoque.Database.Context
{
    public class AppDbContext : DbContext, IDisposable
    {
        public AppDbContext() : base("EstoqueDatabase")
        {            
            Database.CreateIfNotExists();
            Database.Initialize(false);
        }        

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new ProdutoEntityConfig());
            modelBuilder.Configurations.Add(new CategoriaEntityConfig());
            modelBuilder.Configurations.Add(new UsuarioEntityConfig());
            base.OnModelCreating(modelBuilder);
        }

    }
}
