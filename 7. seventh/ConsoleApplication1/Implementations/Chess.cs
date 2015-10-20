using ConsoleApplication1.Interfaces;
using System;

namespace ConsoleApplication1.Implementations
{
    public class Chess : IChess
    {
        public ILogging LogStore { get; set; }

        public string[] PlayerNames { get; set; }

        public void EndGame()
        {
            throw new NotImplementedException();
        }

        public void MakeMove(int player)
        {
            throw new NotImplementedException();
        }

        public void ShowWinner()
        {
            throw new NotImplementedException();
        }

        public void StartGame()
        {
            throw new NotImplementedException();
        }
    }
}
