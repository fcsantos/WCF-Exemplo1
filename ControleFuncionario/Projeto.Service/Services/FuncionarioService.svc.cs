using Projeto.Common;
using Projeto.Entities;
using Projeto.Entities.Types;
using Projeto.Infra.Repository.Contracts;
using Projeto.Service.Models;
using System;
using System.Collections.Generic;

namespace Projeto.Service.Services
{
    public class FuncionarioService : IFuncionarioService
    {
        //injeção de dependencia..
        private readonly IRepositoryFuncionario repository;

        //construtor para o ninject fazer a injeção..
        public FuncionarioService(IRepositoryFuncionario repository)
        {
            this.repository = repository;
        }

        public string Cadastrar(FuncionarioModelCadastro model)
        {
            try
            {
                Funcionario f = new Funcionario();
                f.Endereco = new Endereco();

                f.Nome = model.Nome;
                f.Salario = model.Salario;
                f.DataAdmissao = model.DataAdmissao;
                f.TipoContratacao = (TipoContratacao)
                                    Enum.Parse(typeof(TipoContratacao), model.TipoContratacao);
                f.Endereco.Logradouro = model.Logradouro;
                f.Endereco.Complemento = model.Complemento;
                f.Endereco.Bairro = model.Bairro;
                f.Endereco.Cidade = model.Cidade;
                f.Endereco.UF = model.UF;
                f.Endereco.Cep = model.Cep;

                repository.Insert(f);

                return "Dados gravados.";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string Editar(FuncionarioModelEdicao model)
        {
            try
            {
                var IdFunc = model.IdFuncionario;
                var funcionarioEnd = repository.FindById(IdFunc);

                if (funcionarioEnd != null)
                {
                    funcionarioEnd.Nome = model.Nome;
                    funcionarioEnd.Salario = model.Salario;
                    funcionarioEnd.DataAdmissao = model.DataAdmissao;
                    funcionarioEnd.TipoContratacao = (TipoContratacao)
                                        Enum.Parse(typeof(TipoContratacao), model.TipoContratacao);
                    funcionarioEnd.Endereco.Logradouro = model.Logradouro;
                    funcionarioEnd.Endereco.Complemento = model.Complemento;
                    funcionarioEnd.Endereco.Bairro = model.Bairro;
                    funcionarioEnd.Endereco.Cidade = model.Cidade;
                    funcionarioEnd.Endereco.UF = model.UF;
                    funcionarioEnd.Endereco.Cep = model.Cep;
                }

                repository.Update(funcionarioEnd);

                return "Dados editados.";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string Excluir(int Id)
        {
            try
            {
                var funcionarioEnd = repository.FindById(Id);
                if (funcionarioEnd == null)
                {
                    return "Funcionário não encontrado.";
                }
                else
                {
                    repository.Delete(funcionarioEnd);

                    return "Dados excluídos.";
                }

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public List<DTOFuncionarioEndereco> Consultar()
        {
            return repository.FindAllFuncionarioEndereco();
        }

        public List<DTOQtdFuncionariosTipoContratacao> ConsultarPorTipo()
        {
            return repository.GroupByFuncionarioCategoria();
        }
    }
}
