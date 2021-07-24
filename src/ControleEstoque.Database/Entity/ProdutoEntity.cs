using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.Database.Entity
{
    public class ProdutoEntity
    {
        /// <summary>
        /// Código do produto
        /// </summary>
        public long Codigo { get; set; }

        /// <summary>
        /// Nome do produto
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Descrição do produto
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Unidade básica de medida do produto
        /// </summary>
        public UnidadeMedida UnidadeMedida { get; set; }
    }
}
