using Projeto.Common;
using Projeto.Service.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace Projeto.Service.Services
{
    [ServiceContract] //contrato de serviço
    public interface IFuncionarioService
    {
        [OperationContract] //contrato de método
        string Cadastrar(FuncionarioModelCadastro model);

        [OperationContract] //contrato de método
        List<DTOFuncionarioEndereco> Consultar();

        [OperationContract] //contrato de método
        List<DTOQtdFuncionariosTipoContratacao> ConsultarPorTipo();
    }
}
