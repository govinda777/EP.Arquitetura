using Aluno.Application;
using Aluno.Application.Interfaces;
using Aluno.Data.Context;
using Aluno.Data.Read.Context;
using Aluno.Data.Read.Interfaces;
using Aluno.Data.Read.Repository;
using Aluno.Data.Repository;
using Aluno.Domain.Core.Interfaces;
using Aluno.Domain.Core.Services;
using Kernel.Infra.CQRS.Repositories;
using SimpleInjector;

namespace Aluno.Infra.IoC
{
    public class BootStrapper
    {
        public static Container MyContainer { get; set; }

        public static void Register(Container container)
        {
            // Lifestyle.Transient => Uma instancia para cada solicitacao;
            // Lifestyle.Singleton => Uma instancia unica para a classe;
            // Lifestyle.Scoped => Uma instancia unica para o request;

            MyContainer = container;

            // APP
            container.Register<IAlunoAppService, AlunoAppService>(Lifestyle.Scoped);

            // Domain
            container.Register<IAlunoService, AlunoService>(Lifestyle.Scoped);

            // Infra Dados
            container.Register<IAlunoRepository, AlunoRepository>(Lifestyle.Scoped);
            container.Register<IAlunoReadRepository, AlunoReadRepository>(Lifestyle.Scoped);

            //container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<AlunoContext>(Lifestyle.Scoped);
            container.Register<AlunoReadContext>(Lifestyle.Scoped);
        }
    }
}