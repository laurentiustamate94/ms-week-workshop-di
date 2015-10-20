using Autofac;
using ConsoleApplication1.Implementations;
using ConsoleApplication1.Interfaces;

namespace ConsoleApplication1
{
    public class Container
    {
        public IContainer container;

        public Container()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Chess>().As<IGame>();

            container = builder.Build();
        }
    }
}
