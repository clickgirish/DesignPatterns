using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DesignPatterns.Creational.Singleton.Consumer
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var logger1 = Logger.GetLogger();
            System.Threading.Thread.Sleep(3000);
            var logger2 = Logger.GetLogger();
            System.Threading.Thread.Sleep(3000);
            var logger3 = Logger.GetLogger();
            Console.WriteLine("Done!");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Getting 3 instances of thread safe logger at an interval 3 seconds.");
            var loggerThreadSafe1 = LoggerThreadSafe.GetLogger();
            System.Threading.Thread.Sleep(3000);
            var loggerThreadSafe2 = LoggerThreadSafe.GetLogger();
            System.Threading.Thread.Sleep(3000);
            var loggerThreadSafe3 = LoggerThreadSafe.GetLogger();
            Console.WriteLine("Done!");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Writing CreatedDateTime to ensure that one and only one istance was created in both teh scenarios...");

            Console.WriteLine($"{nameof(logger1)}.{nameof(logger1.CreatedDateTime)}: {logger1.CreatedDateTime}");
            Console.WriteLine($"{nameof(logger2)}.{nameof(logger2.CreatedDateTime)}: {logger2.CreatedDateTime}");
            Console.WriteLine($"{nameof(logger3)}.{nameof(logger3.CreatedDateTime)}: {logger3.CreatedDateTime}");
            Console.WriteLine();
            Console.WriteLine($"{nameof(loggerThreadSafe1)}.{nameof(loggerThreadSafe1.CreatedDateTime)}: {loggerThreadSafe1.CreatedDateTime}");
            Console.WriteLine($"{nameof(loggerThreadSafe2)}.{nameof(loggerThreadSafe2.CreatedDateTime)}: {loggerThreadSafe2.CreatedDateTime}");
            Console.WriteLine($"{nameof(loggerThreadSafe3)}.{nameof(loggerThreadSafe3.CreatedDateTime)}: {loggerThreadSafe3.CreatedDateTime}");
            Console.WriteLine();
            Console.WriteLine($"If you see the {nameof(logger1.CreatedDateTime)} same for all the three instances in first set and all the three instances in the second set, your singleton pattern is working fine! Cheers!");
            Console.ReadLine();
        }
    }
}
