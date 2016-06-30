using Projeto.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Projeto.Infra.Repository.Configurations
{
    public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            HasKey(e => e.IdEndereco);

            Property(e => e.Logradouro)
                .HasMaxLength(250)
                .IsRequired();

            Property(e => e.Complemento)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Bairro)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Cidade)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.UF)
                .HasMaxLength(2)
                .IsRequired();

            Property(e => e.Cep)
                .HasMaxLength(10)
                .IsRequired();

            #region Relacionamentos

            //One to One
            HasRequired(e => e.Funcionario)
                .WithOptional(f => f.Endereco);

            #endregion
        }
    }
}
