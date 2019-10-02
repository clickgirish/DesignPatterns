using System;

namespace DesignPatterns.Behavioral.COR.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            Director director = new Director();
            SeniorDirector seniorDirector = new SeniorDirector();
            VP vP = new VP();

            manager.Next = director;
            director.Next = seniorDirector;
            seniorDirector.Next = vP;
            vP.Next = null;

            string message = manager.ApproveBill(3000);
            Console.WriteLine(message);
            string message2 = manager.ApproveBill(30000);
            Console.WriteLine(message2);
            string message3 = manager.ApproveBill(60000);
            Console.WriteLine(message3);

            Console.ReadLine();
        }
    }
}
