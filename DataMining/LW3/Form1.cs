using LW3.Models;
using LW3.Utillities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW3
{
    public partial class Form1 : Form
    {
        private List<Vector> _vectors;

        public Form1()
        {
            InitializeComponent();
        }

        #region FormMethods
        private void Form1_Load(object sender, EventArgs e)
        {
            clusterCountToolStripTextBox.InitHint("Cluster count");
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filePath = FormUtillity.GetFilePath();

            //_vectors = Utillity.GetVectorsFromFile(filePath)
            //    .OrderBy(m => m.X)
            //    .ThenBy(m => m.Y)
            //    .ToList();

            _vectors = Utillity.GetVectorsFromFile(filePath);

            startToolStripMenuItem.Visible = true;
            clusterCountToolStripTextBox.Visible = true;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartVectors.Visible = true;
            chartAverageDistance.Visible = true;

            chartVectors.Series.Clear();
            chartAverageDistance.Series[0].Points.Clear();

            startToolStripMenuItem.Visible = false;
            clusterCountToolStripTextBox.Visible = false;

            Run();

            startToolStripMenuItem.Visible = true;
            clusterCountToolStripTextBox.Visible = true;
        }
        #endregion

        private void Run()
        {
            if (_vectors.Count == 0)
            {
                return;
            }

            var maxX = _vectors.Select(m => m.X).Max();
            var maxY = _vectors.Select(m => m.Y).Max();

            if (!clusterCountToolStripTextBox.TryParseText(out int clusterCount))
            {
                return;
            }

            var clusters = new List<Cluster>();
            var clustersAverageDistanceDictionary = new Dictionary<int, double>();

            var clusterTasks = new List<Task<double>>(clusterCount);

            for (int i = 1; i <= clusterCount; i++)
            {
                var iterationClusterList = KMeansAlgorythm.InitClusterCentroides(maxX, maxY, i);

                var iterationVectorList = new List<Vector>(_vectors);

                var task = Task.Run(() => KMeansAlgorythm.RunIteration(_vectors, iterationClusterList));

                clusterTasks.Add(task);

                if (i == clusterCount)
                {
                    clusters = iterationClusterList;
                }
            }

            var clusterIndex = 1;

            foreach (var task in clusterTasks)
            {
                var clustersAverageDistance = task.GetAwaiter().GetResult();

                clustersAverageDistanceDictionary.Add(clusterIndex++, clustersAverageDistance);
            }

            FormUtillity.DrawClusters(chartVectors, clusters);

            FormUtillity.DrawAverageDistance(chartAverageDistance, clustersAverageDistanceDictionary);
        }
    }
}
