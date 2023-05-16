using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaFinanceiro.Infra.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Infra.Mappings
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("FUNCIONARIO");

            builder.HasKey(x => x.Id);

            builder.Property(f => f.Id)
                .HasColumnName("ID");

            builder.Property(c => c.Nome)
                 .HasColumnName("NOME")
                 .HasMaxLength(50)
                 .IsRequired();

              builder.Property(c => c.Cpf)
                 .HasColumnName("CPF")
                 .HasMaxLength(11)
                 .IsRequired();

            builder.Property(c => c.Matricula)
                .HasColumnName("MATRICULA")
                .HasMaxLength(25)
                .IsRequired();

            builder.Property(c => c.Salario)
              .HasColumnName("SALARIO")
              .HasMaxLength(4)
              .IsRequired();

        }
    }
}
