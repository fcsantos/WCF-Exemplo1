using Projeto.Common;
using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Infra.Repository.Contracts
{
    public interface IRepositoryFuncionario : IRepositoryBase<Funcionario, int>
    {
        //retornar os dados do Funcionario com Endereco
        List<DTOFuncionarioEndereco> FindAllFuncionarioEndereco();

        //retornar um groupby de categoria com quantidade de funcionarios
        List<DTOQtdFuncionariosTipoContratacao> GroupByFuncionarioCategoria();
    }
}
