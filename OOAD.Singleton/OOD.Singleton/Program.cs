namespace OOD.Singleton
{

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
