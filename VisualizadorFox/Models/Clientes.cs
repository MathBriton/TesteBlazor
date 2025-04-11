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

        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; } = DateTime.Now;

        [StringLength(100, ErrorMessage = "A filiação deve ter no máximo 100 caracteres.")]
        public string Filiacao { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "O cônjuge deve ter no máximo 100 caracteres.")]
        public string Conjuge { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "A profissão deve ter no máximo 100 caracteres.")]
        public string Profissao { get; set; } = string.Empty;

        [Range(0, double.MaxValue, ErrorMessage = "A renda deve ser um valor positivo.")]
        public decimal Renda { get; set; } = 0.0m;

        [Range(0, double.MaxValue, ErrorMessage = "O limite de crédito deve ser um valor positivo.")]
        public decimal LimiteCredito { get; set; } = 0.0m;

        [DataType(DataType.Date)]
        [Display(Name = "Data da Última Compra")]
        public DateTime DataUltCompra { get; set; } = DateTime.Now;

        [StringLength(100, ErrorMessage = "O logradouro deve ter no máximo 100 caracteres.")]
        public string Logradouro { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "O número deve ser maior que zero.")]
        public int Numero { get; set; }

        [StringLength(50, ErrorMessage = "O complemento deve ter no máximo 50 caracteres.")]
        public string Complemento { get; set; } = string.Empty;

        [StringLength(60, ErrorMessage = "O bairro deve ter no máximo 60 caracteres.")]
        public string Bairro { get; set; } = string.Empty;

        [StringLength(60, ErrorMessage = "A cidade deve ter no máximo 60 caracteres.")]
        public string Cidade { get; set; } = string.Empty;

        [StringLength(2, ErrorMessage = "O estado deve ter 2 caracteres.")]
        public string Estado { get; set; } = string.Empty;

        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "CEP deve estar no formato 00000-000.")]
        public string Cep { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        [StringLength(100, ErrorMessage = "O e-mail deve ter no máximo 100 caracteres.")]
        public string Email { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "A observação deve ter no máximo 500 caracteres.")]
        public string Observacao { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [Display(Name = "Data de Cadastro")]
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        [Display(Name = "Data de Alteração")]
        public DateTime DataAlteracao { get; set; } = DateTime.Now;

        [Display(Name = "Está Ativo?")]
        public bool Ativo { get; set; } = true;

    }
}
