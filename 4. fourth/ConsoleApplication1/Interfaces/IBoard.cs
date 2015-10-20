using System.Collections.Generic;

namespace ConsoleApplication1.Interfaces
{
    public interface IBoard
    {
        Dictionary<string, int> ScoreTable { get; set; }

        void ShowTopThree();

        void DisplayBoard(int pageOffset);

        void CreateEntry(string name, string score);
    }
}
