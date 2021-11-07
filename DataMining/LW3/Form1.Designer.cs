
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clusterCountToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.iterationCountToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.vectorsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vectorsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.startToolStripMenuItem,
            this.clusterCountToolStripTextBox,
            this.iterationCountToolStripTextBox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1347, 27);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
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
            // iterationCountToolStripTextBox
            // 
            this.iterationCountToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iterationCountToolStripTextBox.Name = "iterationCountToolStripTextBox";
            this.iterationCountToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            this.iterationCountToolStripTextBox.Visible = false;
            // 
            // vectorsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.vectorsChart.ChartAreas.Add(chartArea1);
            this.vectorsChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vectorsChart.Location = new System.Drawing.Point(0, 27);
            this.vectorsChart.Name = "vectorsChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series1.Name = "Series";
            this.vectorsChart.Series.Add(series1);
            this.vectorsChart.Size = new System.Drawing.Size(1347, 563);
            this.vectorsChart.TabIndex = 6;
            this.vectorsChart.Text = "vectorsChart";
            this.vectorsChart.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 590);
            this.Controls.Add(this.vectorsChart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vectorsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart vectorsChart;
        private System.Windows.Forms.ToolStripTextBox clusterCountToolStripTextBox;
        private System.Windows.Forms.ToolStripTextBox iterationCountToolStripTextBox;
    }
}

