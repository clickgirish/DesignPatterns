using System;

namespace DesignPatterns.Structural.Adapter.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee employee = new EmployeeAdapter();
            string value = employee.GetAllEmployees();

            Console.WriteLine($"Adapter pattern is used for conveerting XML in the Json value and values are ::: \n\n {value}");

            Console.ReadKey();
        }
    }
}
