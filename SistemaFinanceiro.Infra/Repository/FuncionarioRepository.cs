using SistemaFinanceiro.Infra.Contexts;
using SistemaFinanceiro.Infra.Entities;
using SistemaFinanceiro.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFuncionario.Infra.Repository
{
    public class FuncionarioRepository : BaseRepository<Funcionario, Guid>
    {
        public override List<Funcionario> ObterTodos(Func<Funcionario, bool> where)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Funcionarios
                    .Where(where)
                    .ToList();
            }
        }
        public List<Funcionario> GetAll()
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Set<Funcionario>().ToList();
            }
        }
        public override Funcionario? ObterPorId(Guid id)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Funcionarios
                    .Where(c => c.Id == id)
                    .FirstOrDefault();
            }
        }
    }
}
