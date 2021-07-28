using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ControleEstoque.Mvc.ViewModels
{
    public class ProdutoViewModel
    {
        /// <summary>
        /// Código do produto
        /// </summary>        
        public long Codigo { get; set; }

        /// <summary>
        /// Categoria do produto
        /// </summary>        
        public virtual string Categoria { get; set; }

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
        public UnidadeMedidaDto UnidadeMedida { get; set; }

        /// <summary>
        /// Quantidade do produto em estoque
        /// </summary>
        public decimal Quantidade { get; set; } = 0;
    }
}