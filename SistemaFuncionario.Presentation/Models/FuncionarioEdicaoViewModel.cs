using System.ComponentModel.DataAnnotations;

namespace SistemaFuncionario.Presentation.Models
{
    public class FuncionarioEdicaoViewModel
    {
        public Guid? Id { get; set; }
        [MaxLength(150, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe seu nome.")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "Por favor, informe seu cpf.")]
        [MaxLength(11, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        public string? Cpf { get; set; }
        [Required(ErrorMessage = "Por favor, informe sua mátricula.")]
        public string? Matricula { get; set; }
        [Required(ErrorMessage = "Por favor, informe o salário.")]
        public decimal? Salario { get; set; }
        public DateTime? DataCadastro { get; set; }
    }
}
