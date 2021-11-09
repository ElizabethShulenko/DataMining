
namespace LW3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clusterCountToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.chartVectors = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAverageDistance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAverageDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.startToolStripMenuItem,
            this.clusterCountToolStripTextBox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1419, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 23);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Visible = false;
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // clusterCountToolStripTextBox
            // 
            this.clusterCountToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clusterCountToolStripTextBox.Name = "clusterCountToolStripTextBox";
            this.clusterCountToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            this.clusterCountToolStripTextBox.Visible = false;
            // 
            // chartVectors
            // 
            chartArea1.Name = "ChartArea1";
            this.chartVectors.ChartAreas.Add(chartArea1);
            this.chartVectors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartVectors.Location = new System.Drawing.Point(0, 24);
            this.chartVectors.Name = "chartVectors";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series1.Name = "Series";
            this.chartVectors.Series.Add(series1);
            this.chartVectors.Size = new System.Drawing.Size(739, 551);
            this.chartVectors.TabIndex = 6;
            this.chartVectors.Text = "vectorsChart";
            this.chartVectors.Visible = false;
            // 
            // chartAverageDistance
            // 
            chartArea2.Name = "ChartArea1";
            this.chartAverageDistance.ChartAreas.Add(chartArea2);
            this.chartAverageDistance.Dock = System.Windows.Forms.DockStyle.Right;
            legend1.Name = "Legend1";
            this.chartAverageDistance.Legends.Add(legend1);
            this.chartAverageDistance.Location = new System.Drawing.Point(739, 24);
            this.chartAverageDistance.Name = "chartAverageDistance";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.MarkerBorderWidth = 5;
            series2.MarkerSize = 15;
            series2.Name = "Average Distance";
            this.chartAverageDistance.Series.Add(series2);
            this.chartAverageDistance.Size = new System.Drawing.Size(680, 551);
            this.chartAverageDistance.TabIndex = 8;
            this.chartAverageDistance.Text = "chart2";
            this.chartAverageDistance.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 575);
            this.Controls.Add(this.chartVectors);
            this.Controls.Add(this.chartAverageDistance);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVectors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAverageDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVectors;
        private System.Windows.Forms.ToolStripTextBox clusterCountToolStripTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAverageDistance;
    }
}

