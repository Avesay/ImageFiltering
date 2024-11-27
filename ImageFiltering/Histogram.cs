using FastBitmapLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace ImageFiltering
{
    internal class Histogram
    {
        Color[,] pixelColors;
        public Histogram(Color[,] colors)
        {
            pixelColors = colors;
        }
        
        private Chart GetBasicHistogram()
        {
            Chart chart = new();
            chart.Dock = DockStyle.Fill;
            chart.ChartAreas.Add(new ChartArea());
            chart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            /*chart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chart.ChartAreas[0].AxisY.Interval = 300;
            chart.ChartAreas[0].AxisX.Interval = 255;
            chart.ChartAreas[0].AxisX2.Interval = 51;*/
            chart.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;
            chart.ChartAreas[0].AxisX2.Enabled = AxisEnabled.True;
            chart.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chart.ChartAreas[0].AxisX2.LabelStyle.Enabled = false;
            chart.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
            chart.ChartAreas[0].AxisY2.LabelStyle.Enabled = false;
            return chart;
        }
        private Series ValuesToSeries(int[] values)
        {
            var dataPointSeries = new Series
            {
                Name = "Series 1",
                IsVisibleInLegend = false,
                Color = Color.FromArgb(255, 0, 0),
                ChartType = SeriesChartType.Column
            };
            for (int i = 0; i < 256; i++)
            {
                dataPointSeries.Points.AddXY(i, values[i]);
            }
            return dataPointSeries;

        }
        public Chart GetRedChart()
        {
            Chart ChartR = GetBasicHistogram();
            int[] counts = new int[256];
            for (int i = 0; i < pixelColors.GetLength(0); i++)
            { 
                for (int j = 0; j < pixelColors.GetLength(1); j++)
                {
                    counts[pixelColors[i, j].R]++;
                }
            }
            ChartR.Series.Add(ValuesToSeries(counts));
            ChartR.Series["Series 1"]["PixelPointWidth"] = "1";
            return ChartR;
        }
        public Chart GetGreenChart()
        {
            Chart ChartG = GetBasicHistogram();
            int[] counts = new int[256];
            for (int i = 0; i < pixelColors.GetLength(0); i++)
            {
                for (int j = 0; j < pixelColors.GetLength(1); j++)
                {
                    counts[pixelColors[i, j].G]++;
                }
            }
            Series s = ValuesToSeries(counts);
            s.Color = Color.FromArgb(0,255,0);
            ChartG.Series.Add(s);
            ChartG.Series["Series 1"]["PixelPointWidth"] = "1";
            return ChartG;
        }
        public Chart GetBlueChart()
        {
            Chart ChartB = GetBasicHistogram();
            int[] counts = new int[256];
            for (int i = 0; i < pixelColors.GetLength(0); i++)
            {
                for (int j = 0; j < pixelColors.GetLength(1); j++)
                {
                    counts[pixelColors[i, j].B]++;
                }
            }
            Series s = ValuesToSeries(counts);
            s.Color = Color.FromArgb(0, 0, 255);
            ChartB.Series.Add(s);
            ChartB.Series["Series 1"]["PixelPointWidth"] = "1";
            return ChartB;
        }
    }
}
