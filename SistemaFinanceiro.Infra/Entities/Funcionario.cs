using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Infra.Entities
{
    public class Funcionario
    {
        private Guid? _id;
        private string? _nome;
        private string? _cpf;
        private string? _matricula;
        private decimal? _salario;
        private DateTime? _dataCadastro;

        public Guid? Id { get => _id; set => _id = value; }
        public string? Nome { get => _nome; set => _nome = value; }
        public string? Cpf { get => _cpf; set => _cpf = value; }
        public string? Matricula { get => _matricula; set => _matricula = value; }
        public decimal? Salario { get => _salario; set => _salario = value; }
        public DateTime? DataCadastro { get => _dataCadastro; set => _dataCadastro = value; }
    }
}
