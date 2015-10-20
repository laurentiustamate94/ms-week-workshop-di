namespace ConsoleApplication1
{
    public interface IGame
    {
        void StartGame();

        void EndGame();

        void MakeMove(int player);

        void ShowWinner();
    }
}
