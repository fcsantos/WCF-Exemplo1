namespace Projeto.Entities
{
    public class Endereco
    {
        public virtual int IdEndereco { get; set; }
        public virtual string Logradouro { get; set; }
        public virtual string Complemento { get; set; }
        public virtual string Bairro { get; set; }
        public virtual string Cidade { get; set; }
        public virtual string UF { get; set; }
        public virtual string Cep { get; set; }

        #region Relacionamentos

        public virtual Funcionario Funcionario { get; set; }

        #endregion
    }
}
