using AutoMapper;
using SistemaFinanceiro.Infra.Entities;
using SistemaFuncionario.Presentation.Models;

namespace SistemaFuncionario.Presentation.Mappings
{
    public class ModelToEntityMap : Profile
    {
        public ModelToEntityMap() 
        {
            CreateMap<FuncionarioViewModel, Funcionario>()
                .AfterMap((model, entity) =>
                {
                    entity.Id = Guid.NewGuid();
                    entity.Nome = model.Nome;
                    entity.Cpf = model.Cpf;
                    entity.Matricula = model.Matricula;
                    entity.Salario = model.Salario;
                    entity.DataCadastro = DateTime.Now;
                });
        }
    }
}
