using System.ComponentModel.DataAnnotations;

namespace ControleEstoque.Domain.Models
{
    public class Produto
    {
        /// <summary>
        /// Código do produto
        /// </summary>
        [Required]
        public long Codigo { get; set; }

        /// <summary>
        /// Categoria do produto
        /// </summary>
        [Required]
        public virtual Categoria Categoria { get; set; }

        /// <summary>
        /// Nome do produto
        /// </summary>
        [Required]
        [StringLength(50, ErrorMessage = "Nome do produto não pode conter mais do que 50 caracteres")]
        public string Nome { get; set; }

        /// <summary>
        /// Descrição do produto
        /// </summary>
        [Required]
        [StringLength(200, ErrorMessage = "Nome do produto não pode conter mais do que 200 caracteres")]
        public string Descricao { get; set; }

        /// <summary>
        /// Unidade básica de medida do produto
        /// </summary>
        [Required]
        public UnidadeMedida UnidadeMedida { get; set; }

        /// <summary>
        /// Quantidade do produto em estoque
        /// </summary>
        [Required]
        public decimal Quantidade { get; set; } = 0;
    }
}
