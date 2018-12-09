using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace LiveChartDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private class Rawdata
        {
            public DateTime DateTime { get; set; }
            public int Value1 { get; set; }
            public int Value2 { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            var data = new List<Rawdata>()
            {
                new Rawdata(){DateTime =now.AddSeconds(1), Value1 = 0, Value2 = 0},
                new Rawdata(){DateTime =now.AddSeconds(2), Value1 = 1, Value2 = 1},
                new Rawdata(){DateTime =now.AddSeconds(3), Value1 = 0, Value2 = 1},
                new Rawdata(){DateTime =now.AddSeconds(4), Value1 = 1, Value2 = 1},
                new Rawdata(){DateTime =now.AddSeconds(5), Value1 = 1, Value2 = 0},
                new Rawdata(){DateTime =now.AddSeconds(6), Value1 = 0, Value2 = 0},
            };
            StepLineSeries col1 = new StepLineSeries()
            {
                Values = new ChartValues<int>(),
                PointGeometry = null,
            };

            StepLineSeries col2 = new StepLineSeries()
            {
                Values = new ChartValues<int>(),
            };

            Axis ax = new Axis()
            {
                Separator = new Separator() { Step = 1, IsEnabled = false }
            };
            ax.Labels = new List<string>();

            foreach (var item in data)
            {
                col1.Values.Add(item.Value1);
                col2.Values.Add(item.Value2 + 2);
                ax.Labels.Add(item.DateTime.Second.ToString());
            }

            cartesianChart1.Series.Add(col1);
            cartesianChart1.Series.Add(col2);
            cartesianChart1.AxisX.Add(ax);
            cartesianChart1.AxisY.Add(new Axis()
            {
                Labels = new[] {"aaa","", "bbb"}
            });
        }
    }
}