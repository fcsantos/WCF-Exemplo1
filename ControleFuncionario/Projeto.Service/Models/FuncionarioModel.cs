using System;
using System.Runtime.Serialization;

namespace Projeto.Service.Models
{
    [DataContract]
    public class FuncionarioModelCadastro
    {
        [DataMember(IsRequired = true)]
        public string Nome { get; set; }

        [DataMember(IsRequired = true)]
        public decimal Salario { get; set; }

        [DataMember(IsRequired = true)]
        public DateTime DataAdmissao { get; set; }

        [DataMember(IsRequired = true)]
        public string TipoContratacao { get; set; }

        [DataMember(IsRequired = true)]
        public string Logradouro { get; set; }

        [DataMember(IsRequired = true)]
        public string Complemento { get; set; }

        [DataMember(IsRequired = true)]
        public string Bairro { get; set; }

        [DataMember(IsRequired = true)]
        public string Cidade { get; set; }

        [DataMember(IsRequired = true)]
        public string UF { get; set; }

        [DataMember(IsRequired = true)]
        public string Cep { get; set; }
    }

    [DataContract]
    public class FuncionarioModelEdicao
    {
        [DataMember(IsRequired = true)]
        public int IdFuncionario { get; set; }

        [DataMember(IsRequired = true)]
        public string Nome { get; set; }

        [DataMember(IsRequired = true)]
        public decimal Salario { get; set; }

        [DataMember(IsRequired = true)]
        public DateTime DataAdmissao { get; set; }

        [DataMember(IsRequired = true)]
        public string TipoContratacao { get; set; }

        [DataMember(IsRequired = true)]
        public string Logradouro { get; set; }

        [DataMember(IsRequired = true)]
        public string Complemento { get; set; }

        [DataMember(IsRequired = true)]
        public string Bairro { get; set; }

        [DataMember(IsRequired = true)]
        public string Cidade { get; set; }

        [DataMember(IsRequired = true)]
        public string UF { get; set; }

        [DataMember(IsRequired = true)]
        public string Cep { get; set; }
    }
}
