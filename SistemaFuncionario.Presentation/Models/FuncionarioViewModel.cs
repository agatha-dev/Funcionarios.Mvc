using System.ComponentModel.DataAnnotations;

namespace SistemaFuncionario.Presentation.Models
{
    public class FuncionarioViewModel
    {
        [MaxLength(150, ErrorMessage = "Por favor, informe no m�ximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe seu nome.")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "Por favor, informe seu cpf.")]
        [MaxLength(11, ErrorMessage = "Por favor, informe no m�ximo {1} caracteres.")]
        public string? Cpf { get; set; }
        [Required(ErrorMessage = "Por favor, informe sua m�tricula.")]
        public string? Matricula { get; set; }
        [Required(ErrorMessage = "Por favor, informe o sal�rio.")]
        public decimal? Salario { get; set; }
        public DateTime? DataCadastro { get; set; }
    }
}