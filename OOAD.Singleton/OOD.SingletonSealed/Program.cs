using System;

namespace OOD.SingletonSealed
{
    public sealed class SingletonSealed
    {
        private static int counter = 0;
        private static SingletonSealed _instance;

        private SingletonSealed()
        {
            counter++;
            Console.WriteLine($"Count value = {counter}");
        }
        public static SingletonSealed GetInstance
        {
            get
            {
                if (_instance == null)
                    return _instance = new SingletonSealed();
                return _instance;
            }
        }
        public void Write(string message)
        {
            Console.WriteLine($"{message}");
        }
        //public class DerivedSingleton : SingletonSealed
        //{

        //}

    }
    class Program
    {
        static void Main(string[] args)
        {
            var fromTeacher = SingletonSealed.GetInstance;
            fromTeacher.Write("From Teacher");
            var fromStudent = SingletonSealed.GetInstance;
            fromStudent.Write("From Student");
            //SingletonSealed.DerivedSingleton derivedSingleton = new SingletonSealed.DerivedSingleton();
            //derivedSingleton.Write("derived");

        }
    }
}
