namespace ControleEstoque.Domain.Models
{
    public class Produto
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
