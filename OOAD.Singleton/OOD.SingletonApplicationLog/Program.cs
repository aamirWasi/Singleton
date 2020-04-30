using System;

namespace OOD.SingletonApplicationLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{FileLogger.counter}");
            var file = FileLogger.GetFileLogger;
            //file.LogInfoMessage($"Migrating started at : {DateTimeOffset.Now}");
            //file.LogErrorMessage($"Migrating Finished at : {DateTimeOffset.Now}");
            var file2 = FileLogger.GetFileLogger;
            //file2.LogErrorMessage($"file Finished at : {DateTimeOffset.Now}");
            //file2.LogInfoMessage($"file started at : {DateTimeOffset.Now}");
            Console.WriteLine($"{FileLogger.counter}");
        }
    }
}
