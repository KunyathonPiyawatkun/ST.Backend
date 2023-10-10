﻿using NLog;
using ST_API.Interfaces;

namespace ST_API.Service
{
    public class LoggerManager : ILoggerManager
    {
        private static NLog.ILogger logger = LogManager.GetCurrentClassLogger();
        public void LogDebug(string message) => logger?.Debug(message);
        public void LogError(string message) => logger?.Error(message);
        public void LogInfo(string message) => logger?.Info(message);
        public void LogWarning(string message) => logger?.Warn(message);

    }
}
