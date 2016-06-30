using Ninject;
using Ninject.Web.Common;
using Projeto.Infra.Repository.Contracts;
using Projeto.Infra.Repository.Persistence;
using System;

namespace Projeto.Service
{
    public class Global : NinjectHttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        //mapear as dependencias..
        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel();

            kernel.Bind(typeof(IRepositoryBase<,>))
                .To(typeof(RepositoryBase<,>));

            kernel.Bind<IRepositoryFuncionario>()
                .To<RepositoryFuncionario>();

            kernel.Bind<IRepositoryEndereco>()
                .To<RepositoryEndereco>();

            return kernel;
        }

    }
}