using Autofac;
using TwistedTri.ExtraLifeDashboard.Core.Interfaces;
using TwistedTri.ExtraLifeDashboard.Core.Services;

namespace TwistedTri.ExtraLifeDashboard.Core
{
    public class DefaultCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ToDoItemSearchService>()
                .As<IToDoItemSearchService>().InstancePerLifetimeScope();
        }
    }
}