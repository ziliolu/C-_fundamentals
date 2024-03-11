using System;

namespace Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;
        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string message)
        {
            Log(message, "Error");
        }

        public void LogInfo(string message)
        {
            Log(message, "Error");
        }

        private void Log(string message, string messageType)
        {
            using (var StreamWriter = new StreamWriter(_path, true))
            {
                StreamWriter.WriteLine(messageType + ": " + message);
                StreamWriter.Dispose();
            }
        }
    }
}
