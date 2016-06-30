using Projeto.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Projeto.Infra.Repository.Configurations
{
    public class FuncionarioConfiguration : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioConfiguration()
        {
            HasKey(f => f.IdFuncionario);

            Property(f => f.Nome)
                .HasMaxLength(50)
                .IsRequired();

            Property(f => f.Salario)
                .HasPrecision(18, 2)
                .IsRequired();

            Property(f => f.DataAdmissao)
                .IsRequired();

            Property(f => f.TipoContratacao)
                .IsRequired();
        }
    }
}
