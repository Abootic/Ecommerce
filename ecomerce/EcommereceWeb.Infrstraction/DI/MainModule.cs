using Autofac;


namespace EcommereceWeb.Infrstraction.DI
{
    public class MainModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.Load("EcommereceWeb.Infrstraction"))
                .Where(t=>t.Name.EndsWith("Repository")||t.Name.EndsWith("Manager")).AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
