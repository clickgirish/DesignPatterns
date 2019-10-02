using System;
using System.Threading;

namespace DesignPatterns.Behavioral.Observer
{
    public class Chart
    {
        
    }

    public class PieChart : Chart
    {
        Data data;
        public PieChart(Data data)
        {
            this.data = data;
            this.data.OnDataChanged += Data_OnDataChanged;
        }

        private void Data_OnDataChanged(int[] data)
        {
            Console.WriteLine("Updated pie chart data");
        }
    }

    public class DonutChart : Chart
    {
        Data data;
        public DonutChart(Data data)
        {
            this.data = data;
            this.data.OnDataChanged += Data_OnDataChanged;
        }

        private void Data_OnDataChanged(int[] data)
        {
            Console.WriteLine("Updated donut chart data");
        }
    }

    public class LineChart : Chart
    {
        Data data;
        public LineChart(Data data)
        {
            this.data = data;
            this.data.OnDataChanged += Data_OnDataChanged;
        }

        private void Data_OnDataChanged(int[] data)
        {
            Console.WriteLine("Updated Line chart data");
        }
    }

    public class Data
    {
        public delegate void DataChanged(int[] data);

        public event DataChanged OnDataChanged;

        public void ChangeData(int[] updatedData)
        {
            Console.WriteLine("Updating data");
            Thread.Sleep(3000);

            OnDataChanged?.Invoke(updatedData);
        }
    }

}
