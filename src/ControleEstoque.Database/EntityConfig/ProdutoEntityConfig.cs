using ControleEstoque.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace ControleEstoque.Database.EntityConfig
{
    public class ProdutoEntityConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoEntityConfig()
        {
            HasKey(p => p.Codigo);

            Property(p => p.Codigo)
                .IsRequired();

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(200);

            Property(p => p.UnidadeMedida)
                .IsRequired();

            HasRequired<Categoria>(s => s.Categoria)
                .WithMany(g => g.Produtos);

            ToTable("Produtos");
        }
    }
}
