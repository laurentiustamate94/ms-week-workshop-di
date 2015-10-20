using ConsoleApplication1.Interfaces;
using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Implementations
{
    public class MoveLogging : ILogging
    {
        public Dictionary<string, string> LogTable
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string GetLoggedDataByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Log(string name, string eventDetail)
        {
            throw new NotImplementedException();
        }
    }
}
