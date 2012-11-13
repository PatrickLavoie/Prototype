using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MSChartInWpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<int, double> value;
        public MainWindow()
        {
            InitializeComponent();

            value = new Dictionary<int, double>();
            for (int i = 0; i < 10; i++)
                value.Add(i, 10 * i);

            Chart chart = this.FindName("MyWinformChart") as Chart;

            //DesignChart(chart);  

            chart.DataSource = value;
            chart.Series["series"].XValueMember = "Key";
            chart.Series["series"].YValueMembers = "Value";
        }

        private void DesignChart(Chart chart1)
        {
           
            // 
            // chart1
            // 
            chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            chart1.BackSecondaryColor = System.Drawing.Color.White;
            chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart1.BorderSkin.BackColor = System.Drawing.Color.CornflowerBlue;
            chart1.BorderSkin.BackSecondaryColor = System.Drawing.Color.CornflowerBlue;
            chart1.BorderSkin.PageColor = System.Drawing.SystemColors.Control;
            chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chart1.ChartAreas[0].AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chart1.ChartAreas[0].AxisX2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chart1.ChartAreas[0].AxisX2.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chart1.ChartAreas[0].AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chart1.ChartAreas[0].AxisY2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chart1.ChartAreas[0].AxisY2.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chart1.ChartAreas[0].BackColor = System.Drawing.Color.White;
            chart1.ChartAreas[0].BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            chart1.ChartAreas[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart1.ChartAreas[0].ShadowOffset = 2;

            chart1.Invalidate();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Random myRandom = new Random();

            for (int i = 0; i < 10; i++)
            {
                value[i] = myRandom.NextDouble();
            }

            Chart chart = this.FindName("MyWinformChart") as Chart;
            chart.DataBind();

            chart.Invalidate();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Chart chart = this.FindName("MyWinformChart") as Chart;

            DesignChart(chart);            

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Chart chart = this.FindName("MyWinformChart") as Chart;

            chart.Legends.Clear();

            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();

            legend1.BackColor = System.Drawing.Color.White;
            legend1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Table;
            legend1.Name = "Default";
            legend1.ShadowOffset = 2;

            chart.Legends.Add(legend1);

            chart.Invalidate();
        }
    }

}
