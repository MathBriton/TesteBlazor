using System.ComponentModel.DataAnnotations;

namespace VisualizadorFox.Models
{
    public class Produtos
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [StringLength(100, ErrorMessage = "A descrição deve ter no máximo 100 caracteres.")]
        public string Descricao { get; set; } = string.Empty;

        [Required(ErrorMessage = "A quantidade é obrigatória.")]
        [Range(0, int.MaxValue, ErrorMessage = "A quantidade deve ser maior ou igual a zero.")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "O preço de custo é obrigatório.")]
        [Range(0, double.MaxValue, ErrorMessage = "O preço de custo deve ser positivo.")]
        public decimal PrecoCusto { get; set; }

        [Required(ErrorMessage = "O preço médio é obrigatório.")]
        [Range(0, double.MaxValue, ErrorMessage = "O preço médio deve ser positivo.")]
        public decimal PrecoMedio { get; set; }

        [Required(ErrorMessage = "O preço de venda é obrigatório.")]
        [Range(0, double.MaxValue, ErrorMessage = "O preço de venda deve ser positivo.")]
        public decimal PrecoVenda { get; set; }

        [Required(ErrorMessage = "A comissão é obrigatória.")]
        [Range(0, 100, ErrorMessage = "A comissão deve estar entre 0 e 100.")]
        public decimal Comissao { get; set; }

        [StringLength(50, ErrorMessage = "A classificação deve ter no máximo 50 caracteres.")]
        public string Classificacao { get; set; } = string.Empty;

        [StringLength(50, ErrorMessage = "O grupo deve ter no máximo 50 caracteres.")]
        public string Grupo { get; set; } = string.Empty;

        [StringLength(50, ErrorMessage = "O subgrupo deve ter no máximo 50 caracteres.")]
        public string SubGrupo { get; set; } = string.Empty;
    }
}
