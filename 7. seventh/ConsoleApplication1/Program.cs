using Autofac;
using ConsoleApplication1.Interfaces;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var resolver = new Container();

            var chess = resolver.container.Resolve<IChess>();
            var chessNotSingleInstance = resolver.container.Resolve<IChess>();

            chess.PlayerNames = new string[] { "Laurentiu" };


            
            var backgammon = resolver.container.Resolve<IBackgammon>();
            var backgammonSingleInstance = resolver.container.Resolve<IBackgammon>();

            backgammon.PlayerNames = new string[] { "Laurentiu Single Instance" };
        }
    }
}
