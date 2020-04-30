namespace OOD.SingletonClass11
{
    public class Motor
    {
        private static Motor _motor;
        public static int counter = 0;
        private Motor()
        {
            counter++;
        }
        public static Motor GetMotor
        {
            get
            {
                if (_motor == null)
                    return _motor = new Motor();
                return _motor;
            }
        }
    }
}
