using System.ComponentModel.DataAnnotations;

namespace ControleEstoque.Mvc.ViewModels
{
    public class CategoriaViewModel
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
    }
}