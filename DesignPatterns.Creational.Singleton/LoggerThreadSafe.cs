using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Singleton
{
    public class LoggerThreadSafe
    {
        private static LoggerThreadSafe logger;
        private static object baton = new object();
        public DateTime CreatedDateTime { get; private set; }

        private LoggerThreadSafe()
        {
            CreatedDateTime = DateTime.Now;
        }

        public static LoggerThreadSafe GetLogger()
        {
            if (logger == null)
            {
                lock (baton)
                {
                    if (logger == null)
                    {
                        logger = new LoggerThreadSafe();
                    }
                }
            }

            return logger;
        }
    }
}
