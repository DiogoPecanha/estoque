using System.ComponentModel.DataAnnotations;

namespace ControleEstoque.Domain.Models
{
    public enum UnidadeMedida
    {
        [Display(Name = "Quilograma")]
        KG = 1,
        [Display(Name = "Litro")]
        LT,
        [Display(Name = "Unidade")]
        UN,
        [Display(Name = "Metro linear")]
        MT,
        [Display(Name = "Metro quadrado")]
        M2,
        [Display(Name = "Metro cúbico")]
        M3
    }
}
