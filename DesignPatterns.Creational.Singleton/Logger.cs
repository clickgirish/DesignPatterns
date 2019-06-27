using System;

namespace DesignPatterns.Creational.Singleton
{
    public class Logger
    {
        private static Logger logger;
        public DateTime CreatedDateTime { get; private set; }

        private Logger()
        {
            CreatedDateTime = DateTime.Now;
        }

        public static Logger GetLogger()
        {
            if (logger == null)
            {
                logger = new Logger();
            }

            return logger;
        }
    }
}
