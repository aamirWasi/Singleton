using System;

namespace OOD.Singleton
{
    public class ConsoleLoggerCilent : IConsoleLoggerCilent
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
