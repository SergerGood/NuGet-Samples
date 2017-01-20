namespace AppLogger.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new AppLogger.LoggerClass();
            logger.Log(string.Empty);
        }
    }
}
