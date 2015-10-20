using System.Collections.Generic;

namespace ConsoleApplication1.Interfaces
{
    public interface ILogging
    {
        Dictionary<string, string> LogTable { get; set; }

        void Log(string name, string eventDetail);

        string GetLoggedDataByName(string name);
    }
}
