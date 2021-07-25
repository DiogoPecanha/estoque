using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ControleEstoque.Domain.Models
{
    public class Categoria
    {
        /// <summary>
        /// Codigo da categoria
        /// </summary>
        [Required]
        public long Codigo { get; set; }

        /// <summary>
        /// Nome da categoria
        /// </summary>
        [Required]
        public string Nome { get; set; }

        /// <summary>
        /// Produtos pertencentes a categoria
        /// </summary>
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
