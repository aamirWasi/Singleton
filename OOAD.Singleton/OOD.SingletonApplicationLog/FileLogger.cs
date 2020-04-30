using System;
using System.IO;

namespace OOD.SingletonApplicationLog
{
    public class FileLogger : IConsoleLogger
    {
        static int counter = 0;
        private static FileLogger _fileLogger;
        private string _path;
        private FileLogger(string path)
        {
            _path = path;
            counter++;
            Console.WriteLine($"{counter}");
        }
        public static FileLogger GetFileLogger
        {
            get
            {
                if (_fileLogger == null)
                    return _fileLogger = new FileLogger(@"E:\log.txt");
                return _fileLogger;
            }
        }
        public void LogErrorMessage(string message)
        {
            Log("ERROR", message);
        }
        public void LogInfoMessage(string message)
        {
            Log("INFO", message);
        }
        private void Log(string messageType, string message)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine($"{messageType} : {message}");
            }
        }

    }
}
