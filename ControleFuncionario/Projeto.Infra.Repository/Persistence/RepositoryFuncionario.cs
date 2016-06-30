using Projeto.Common;
using Projeto.Entities;
using Projeto.Infra.Repository.Context;
using Projeto.Infra.Repository.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Projeto.Infra.Repository.Persistence
{
    public class RepositoryFuncionario : RepositoryBase<Funcionario, int>, IRepositoryFuncionario
    {
        public List<DTOFuncionarioEndereco> FindAllFuncionarioEndereco()
        {
            using (DataContext d = new DataContext())
            {
                return d.Funcionarios //consulta em Funcionario..
                        .Include(f => f.Endereco) //Join com Endereco..
                        .Select( //selecionar os campos e coloca-los no DTO..
                            f => new DTOFuncionarioEndereco()
                            {
                                IdFuncionario = f.IdFuncionario,
                                Nome = f.Nome,
                                Salario = f.Salario,
                                DataAdmissao = f.DataAdmissao,
                                TipoContratacao = f.TipoContratacao.ToString(),
                                Logradouro = f.Endereco.Logradouro,
                                Complemento = f.Endereco.Complemento,
                                Bairro = f.Endereco.Bairro,
                                Cidade = f.Endereco.Cidade,
                                UF = f.Endereco.UF,
                                Cep = f.Endereco.Cep
                            }
                        )
                        .OrderBy(dto => dto.IdFuncionario)
                        .ToList();
            }
        }

        public List<DTOQtdFuncionariosTipoContratacao> GroupByFuncionarioCategoria()
        {
            using (DataContext d = new DataContext())
            {
                return d.Funcionarios
                        .GroupBy(f => new { f.TipoContratacao })
                        .Select(
                            group => new DTOQtdFuncionariosTipoContratacao()
                            {
                                TipoContratacao = group.Key.TipoContratacao.ToString(),
                                QtdFuncionarios = group.Count()
                            }
                        )
                        .OrderByDescending(dto => dto.QtdFuncionarios)
                        .ToList();
            }
        }
    }
}
