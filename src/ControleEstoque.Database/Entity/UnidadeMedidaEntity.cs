using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.Database.Entity
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
