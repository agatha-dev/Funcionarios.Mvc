using Microsoft.EntityFrameworkCore;
using SistemaFinanceiro.Infra.Entities;
using SistemaFinanceiro.Infra.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Infra.Contexts
{
    /// <summary>
    /// Contexto do EntityFramework
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Método para configurar a conexão de banco de dados
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBSistemaFuncionario;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FuncionarioMap());
        }
        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}
