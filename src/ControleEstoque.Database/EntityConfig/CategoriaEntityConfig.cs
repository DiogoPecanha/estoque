using ControleEstoque.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace ControleEstoque.Database.EntityConfig
{
    public class CategoriaEntityConfig : EntityTypeConfiguration<Categoria>
    {
        public CategoriaEntityConfig()
        {
            HasKey(c => c.Codigo);

            Property(p => p.Codigo)
                .IsRequired();

            Property(c => c.Nome)
                .HasMaxLength(100)
                .IsRequired();

            HasMany<Produto>(c => c.Produtos)
                .WithRequired(c => c.Categoria)                
                .WillCascadeOnDelete(false);

            ToTable("Categorias");
        }
    }
}
