using System.ComponentModel.DataAnnotations;

namespace VisualizadorFox.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [RegularExpression(@"\d{3}\.\d{3}\.\d{3}-\d{2}", ErrorMessage = "CPF deve estar no formato 000.000.000-00")]
        public string Cpf { get; set; } = string.Empty;

        [Phone(ErrorMessage = "Número de telefone inválido.")]
        [StringLength(20, ErrorMessage = "O telefone deve ter no máximo 20 caracteres.")]
        public string Telefone { get; set; } = string.Empty;
    }
}
