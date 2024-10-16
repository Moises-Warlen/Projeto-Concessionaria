using Concessionaria.Domain.Teste;
using Concessionaria.Repository;
using Concessionaria.Repository.Infra;
using SimpleInjector;
using SimpleInjector.Lifestyles;

namespace Concessionaria.Api
{
    public static class SimpleInjectorContainer
    {
        private static readonly Container Container = new Container();

        public static Container Build()
        {
            Container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            Container.Register<IDatabaseConnection, DatabaseConnection>(Lifestyle.Scoped);
            //Container.Register<Notification>(Lifestyle.Scoped);

            RegisterRepositories();

            Container.Verify();
            return Container;
        }

        private static void RegisterRepositories()
        {
            Container.Register<ITesteRepository, TesteRepository>();
        }
    }
}