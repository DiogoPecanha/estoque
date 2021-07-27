using System.ComponentModel.DataAnnotations;

namespace ControleEstoque.Mvc.ViewModels
{
    public enum UnidadeMedidaDto
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