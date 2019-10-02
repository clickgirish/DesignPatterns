using System;
using System.Threading;

namespace DesignPatterns.Behavioral.Observer.Publisher
{
    class DataPublisher
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            // if price is greter than 100
            PieChart pieChart = new PieChart(data);
            DonutChart donutChart = new DonutChart(data);
            LineChart lineChart = new LineChart(data);

            int[] array = { 5, 9, 6 };
            data.ChangeData(array);

            Console.ReadLine();
        }
    }
}
