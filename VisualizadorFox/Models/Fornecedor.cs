using System.ComponentModel.DataAnnotations;

namespace VisualizadorFox.Models
{
    public class Fornecedor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome fantasia é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome fantasia deve ter no máximo 100 caracteres.")]
        public string Fantasia { get; set; } = string.Empty;

        [Required(ErrorMessage = "A razão social é obrigatória.")]
        [StringLength(150, ErrorMessage = "A razão social deve ter no máximo 150 caracteres.")]
        public string RazaoSocial { get; set; } = string.Empty;

        [Phone(ErrorMessage = "Telefone inválido.")]
        [StringLength(20, ErrorMessage = "O telefone deve ter no máximo 20 caracteres.")]
        public string Telefone { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "A rua deve ter no máximo 100 caracteres.")]
        public string Rua { get; set; } = string.Empty;

        [StringLength(60, ErrorMessage = "O bairro deve ter no máximo 60 caracteres.")]
        public string Bairro { get; set; } = string.Empty;

        [StringLength(60, ErrorMessage = "O município deve ter no máximo 60 caracteres.")]
        public string Municipio { get; set; } = string.Empty;

        [RegularExpression(@"\d{3}\.\d{3}\.\d{3}-\d{2}", ErrorMessage = "CPF deve estar no formato 000.000.000-00")]
        public string CPF { get; set; } = string.Empty;

        [RegularExpression(@"\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}", ErrorMessage = "CNPJ deve estar no formato 00.000.000/0000-00")]
        public string CNPJ { get; set; } = string.Empty;
    }
}
