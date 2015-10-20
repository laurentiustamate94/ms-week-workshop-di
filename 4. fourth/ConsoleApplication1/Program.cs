using Autofac;
using ConsoleApplication1.Interfaces;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var resolver = new Container();

            var chess = resolver.container.Resolve<IGame>();
        }
    }
}
