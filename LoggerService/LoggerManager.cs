using Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerService
{
    public class LoggerManager : ILoggerManager
    {

        public LoggerManager()
        {

        }
        public void LogDebug(string message)
        {
            throw new NotImplementedException();
        }

        public void LogError(string message)
        {
            message = "Logging error";
        }

        public void LogSuccess(string message)
        {
            throw new NotImplementedException();
        }

        public void LogWarning(string message)
        {
            throw new NotImplementedException();
        }
    }
}
