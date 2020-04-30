using System;

namespace OOD.SingletonClass11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Motor.counter);
            var motor1 = Motor.GetMotor;
            var motor2 = Motor.GetMotor;
            var motor3 = Motor.GetMotor;
            Console.WriteLine(Motor.counter);
        }
    }
}
