namespace ConsoleApplication1.Interfaces
{
    public interface IGame
    {
        string[] PlayerNames { get; set; }

        void StartGame();

        void EndGame();

        void MakeMove(int player);

        void ShowWinner();
    }
}
