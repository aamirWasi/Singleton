using System;

namespace OOD.Singleton
{
    public interface IConsoleLoggerCilent
    {
        void Write(string message);
    }

    public class ConsoleLoggerCilent : IConsoleLoggerCilent
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Singleton
    {
        private static int counter = 0;
        private static Singleton _instance;

        private Singleton()
        {
            counter++;
            Console.WriteLine($"Count value = {counter}");
        }
        public static Singleton GetInstance()
        {
            if (_instance == null)
                return _instance = new Singleton();
            return _instance;
        }
        public void Write(string message)
        {
            Console.WriteLine($"{message}");
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            var fromTeacher = Singleton.GetInstance();
            fromTeacher.Write("From Teacher");
            var fromStudent = Singleton.GetInstance();
            fromStudent.Write("From Student");
        }
    }
}
