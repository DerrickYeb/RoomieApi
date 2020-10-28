using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface ILoggerManager
    {
        void LogError(string message);
        void LogWarning(string message);
        void LogSuccess(string message);
        void LogDebug(string message);
    }
}
