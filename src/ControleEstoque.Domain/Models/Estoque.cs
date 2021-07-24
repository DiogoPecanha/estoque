using System;
using System.Collections.Generic;
using System.Text;

namespace ControleEstoque.Domain.Models
{
    public class Estoque
    {
        /// <summary>
        /// Produto 
        /// </summary>
        public Produto Produto { get; set; }

        /// <summary>
        /// Quantidade do produto em estoque
        /// </summary>
        public decimal Quantidade { get; set; }
    }
}
