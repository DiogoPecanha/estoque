using ControleEstoque.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace ControleEstoque.Database.EntityConfig
{
    public class UsuarioEntityConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioEntityConfig()
        {
            HasKey(u => u.Id);

            Property(u => u.Id)
                .IsRequired();

            Property(u => u.UserName)
                .HasMaxLength(20)
                .IsRequired();

            Property(u => u.NomeCompleto)
                .HasMaxLength(256)
                .IsRequired();
            
            Property(u => u.Email)
                .HasMaxLength(256)
                .IsRequired();
            
            Property(u => u.Password)
                .HasMaxLength(10)
                .IsRequired();

            ToTable("Usuarios");
        }
    }
}
