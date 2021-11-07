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
            iterationCountToolStripTextBox.InitHint("Iteration count");
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
            iterationCountToolStripTextBox.Visible = true;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vectorsChart.Visible = true;

            vectorsChart.Series.Clear();

            startToolStripMenuItem.Visible = false;
            clusterCountToolStripTextBox.Visible = false;
            iterationCountToolStripTextBox.Visible = false;

            Run();

            startToolStripMenuItem.Visible = true;
            clusterCountToolStripTextBox.Visible = true;
            iterationCountToolStripTextBox.Visible = true;
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

            if (!clusterCountToolStripTextBox.TryParseText(out int clusterAmount))
            {
                return;
            }

            var clusters = KMeansAlgorythm.InitClusterCentroides(maxX, maxY, clusterAmount);

            if (!iterationCountToolStripTextBox.TryParseText(out int iterationCount))
            {
                return;
            }

            for (int i = 0; i < iterationCount; i++)
            {
                Task.Run(() => KMeansAlgorythm.CleanClusterVector(ref clusters)).GetAwaiter().GetResult();

                Task.Run(() => KMeansAlgorythm.CountClusters(ref clusters, _vectors)).GetAwaiter().GetResult();

                FormUtillity.DrawClusters(vectorsChart, clusters);
            }
        }
    }
}
