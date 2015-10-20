namespace ConsoleApplication1
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
