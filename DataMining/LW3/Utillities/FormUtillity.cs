using LW3.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LW3.Utillities
{
    public static class FormUtillity
    {
        public static string GetFilePath()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "./lw3DataMining";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
            }

            return String.Empty;
        }

        public static void DrawClusters(Chart chart, IEnumerable<Cluster> clusters)
        {
            chart.Series.Clear();

            foreach (var cluster in clusters)
            {
                var series = GetClusterSeries(cluster);

                chart.Series.Add(series);

                //var centroidSeries = GetCentroidSeries(cluster.Centroid);

                //chart.Series.Add(centroidSeries);
            }
        }

        public static void DrawAverageDistance(Chart chart, Dictionary<int, double> dictionary)
        {
            chart.Series[0].Points.Clear();

            foreach (var item in dictionary)
            {
                chart.Series[0].Points.AddXY(item.Key, item.Value);
            }
        }

        public static Series GetClusterSeries(Cluster cluster)
        {
            var series = new Series();

            series.ChartType = SeriesChartType.Point;
            series.IsVisibleInLegend = false;

            foreach (var vector in cluster.Vectors)
            {
                series.Points.AddXY(vector.X, vector.Y);
            }

            return series;
        }

        public static Series GetCentroidSeries(Vector centroid)
        {
            var series = new Series();

            series.ChartType = SeriesChartType.Bubble;
            series.IsVisibleInLegend = false;
            series["BubbleScaleMin"] = "0";

            series.Points.AddXY(centroid.X, centroid.Y);

            return series;
        }

        public static bool TryParseText(this ToolStripTextBox textBox, out int result)
        {
            return Int32.TryParse(textBox.Text, out result);
        }
    }
}
