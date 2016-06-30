using Projeto.Entities.Types;
using System;

namespace Projeto.Entities
{
    public class Funcionario
    {
        public virtual int IdFuncionario { get; set; }
        public virtual string Nome { get; set; }
        public virtual decimal Salario { get; set; }
        public virtual DateTime DataAdmissao { get; set; }
        public virtual TipoContratacao TipoContratacao { get; set; }

        #region Relacionamentos

        public virtual Endereco Endereco { get; set; }

        #endregion
    }
}
