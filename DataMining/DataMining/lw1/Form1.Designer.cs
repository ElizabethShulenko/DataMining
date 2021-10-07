
namespace LW1
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonStart = new System.Windows.Forms.Button();
            this.chartHamWordLength = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelHamAverageLength = new System.Windows.Forms.Label();
            this.labelSpamAverageLength = new System.Windows.Forms.Label();
            this.chartSpamWordLength = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSpamNoticeLength = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartHamNoticeLength = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelHamNoticeAvgLength = new System.Windows.Forms.Label();
            this.labelSpamNoticeAvgLength = new System.Windows.Forms.Label();
            this.chartHamFrequentWords = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSpamFrequentWords = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartHamWordLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpamWordLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpamNoticeLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHamNoticeLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHamFrequentWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpamFrequentWords)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(1162, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(149, 38);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // chartHamWordLength
            // 
            chartArea1.Name = "ChartArea1";
            this.chartHamWordLength.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartHamWordLength.Legends.Add(legend1);
            this.chartHamWordLength.Location = new System.Drawing.Point(12, 12);
            this.chartHamWordLength.Name = "chartHamWordLength";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "HamWordsLength";
            this.chartHamWordLength.Series.Add(series1);
            this.chartHamWordLength.Size = new System.Drawing.Size(551, 398);
            this.chartHamWordLength.TabIndex = 1;
            this.chartHamWordLength.Text = "chart1";
            // 
            // labelHamAverageLength
            // 
            this.labelHamAverageLength.AutoSize = true;
            this.labelHamAverageLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelHamAverageLength.Location = new System.Drawing.Point(1126, 202);
            this.labelHamAverageLength.Name = "labelHamAverageLength";
            this.labelHamAverageLength.Size = new System.Drawing.Size(90, 17);
            this.labelHamAverageLength.TabIndex = 3;
            this.labelHamAverageLength.Text = "HamAverage";
            // 
            // labelSpamAverageLength
            // 
            this.labelSpamAverageLength.AutoSize = true;
            this.labelSpamAverageLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSpamAverageLength.Location = new System.Drawing.Point(1126, 624);
            this.labelSpamAverageLength.Name = "labelSpamAverageLength";
            this.labelSpamAverageLength.Size = new System.Drawing.Size(97, 17);
            this.labelSpamAverageLength.TabIndex = 4;
            this.labelSpamAverageLength.Text = "SpamAverage";
            // 
            // chartSpamWordLength
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSpamWordLength.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSpamWordLength.Legends.Add(legend2);
            this.chartSpamWordLength.Location = new System.Drawing.Point(12, 416);
            this.chartSpamWordLength.Name = "chartSpamWordLength";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "SpamWordsLength";
            this.chartSpamWordLength.Series.Add(series2);
            this.chartSpamWordLength.Size = new System.Drawing.Size(551, 396);
            this.chartSpamWordLength.TabIndex = 6;
            this.chartSpamWordLength.Text = "chart1";
            // 
            // chartSpamNoticeLength
            // 
            chartArea3.Name = "ChartArea1";
            this.chartSpamNoticeLength.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartSpamNoticeLength.Legends.Add(legend3);
            this.chartSpamNoticeLength.Location = new System.Drawing.Point(569, 416);
            this.chartSpamNoticeLength.Name = "chartSpamNoticeLength";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Legend = "Legend1";
            series3.Name = "SpamNoticeLength";
            this.chartSpamNoticeLength.Series.Add(series3);
            this.chartSpamNoticeLength.Size = new System.Drawing.Size(551, 396);
            this.chartSpamNoticeLength.TabIndex = 7;
            this.chartSpamNoticeLength.Text = "chart1";
            // 
            // chartHamNoticeLength
            // 
            chartArea4.Name = "ChartArea1";
            this.chartHamNoticeLength.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartHamNoticeLength.Legends.Add(legend4);
            this.chartHamNoticeLength.Location = new System.Drawing.Point(569, 12);
            this.chartHamNoticeLength.Name = "chartHamNoticeLength";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Legend = "Legend1";
            series4.Name = "HamNoticeLength";
            this.chartHamNoticeLength.Series.Add(series4);
            this.chartHamNoticeLength.Size = new System.Drawing.Size(551, 398);
            this.chartHamNoticeLength.TabIndex = 8;
            this.chartHamNoticeLength.Text = "chart1";
            // 
            // labelHamNoticeAvgLength
            // 
            this.labelHamNoticeAvgLength.AutoSize = true;
            this.labelHamNoticeAvgLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelHamNoticeAvgLength.Location = new System.Drawing.Point(1126, 231);
            this.labelHamNoticeAvgLength.Name = "labelHamNoticeAvgLength";
            this.labelHamNoticeAvgLength.Size = new System.Drawing.Size(101, 17);
            this.labelHamNoticeAvgLength.TabIndex = 9;
            this.labelHamNoticeAvgLength.Text = "HamNoticeAvg";
            // 
            // labelSpamNoticeAvgLength
            // 
            this.labelSpamNoticeAvgLength.AutoSize = true;
            this.labelSpamNoticeAvgLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSpamNoticeAvgLength.Location = new System.Drawing.Point(1126, 650);
            this.labelSpamNoticeAvgLength.Name = "labelSpamNoticeAvgLength";
            this.labelSpamNoticeAvgLength.Size = new System.Drawing.Size(108, 17);
            this.labelSpamNoticeAvgLength.TabIndex = 10;
            this.labelSpamNoticeAvgLength.Text = "SpamNoticeAvg";
            // 
            // chartHamFrequentWords
            // 
            chartArea5.AxisX.Interval = 1D;
            chartArea5.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea5.Name = "ChartArea1";
            this.chartHamFrequentWords.ChartAreas.Add(chartArea5);
            legend5.IsTextAutoFit = false;
            legend5.Name = "Legend1";
            this.chartHamFrequentWords.Legends.Add(legend5);
            this.chartHamFrequentWords.Location = new System.Drawing.Point(1361, 12);
            this.chartHamFrequentWords.Name = "chartHamFrequentWords";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.MarkerSize = 1;
            series5.Name = "HamFrequentWords";
            series5.SmartLabelStyle.Enabled = false;
            this.chartHamFrequentWords.Series.Add(series5);
            this.chartHamFrequentWords.Size = new System.Drawing.Size(551, 398);
            this.chartHamFrequentWords.TabIndex = 11;
            this.chartHamFrequentWords.Text = "chart1";
            // 
            // chartSpamFrequentWords
            // 
            chartArea6.AxisX.Interval = 1D;
            chartArea6.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea6.Name = "ChartArea1";
            this.chartSpamFrequentWords.ChartAreas.Add(chartArea6);
            legend6.IsTextAutoFit = false;
            legend6.Name = "Legend1";
            this.chartSpamFrequentWords.Legends.Add(legend6);
            this.chartSpamFrequentWords.Location = new System.Drawing.Point(1361, 416);
            this.chartSpamFrequentWords.Name = "chartSpamFrequentWords";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.MarkerSize = 1;
            series6.Name = "SpamFrequentWords";
            series6.SmartLabelStyle.Enabled = false;
            this.chartSpamFrequentWords.Series.Add(series6);
            this.chartSpamFrequentWords.Size = new System.Drawing.Size(551, 398);
            this.chartSpamFrequentWords.TabIndex = 12;
            this.chartSpamFrequentWords.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 963);
            this.Controls.Add(this.chartSpamFrequentWords);
            this.Controls.Add(this.chartHamFrequentWords);
            this.Controls.Add(this.labelSpamNoticeAvgLength);
            this.Controls.Add(this.labelHamNoticeAvgLength);
            this.Controls.Add(this.chartHamNoticeLength);
            this.Controls.Add(this.chartSpamNoticeLength);
            this.Controls.Add(this.chartSpamWordLength);
            this.Controls.Add(this.labelSpamAverageLength);
            this.Controls.Add(this.labelHamAverageLength);
            this.Controls.Add(this.chartHamWordLength);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chartHamWordLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpamWordLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpamNoticeLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHamNoticeLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHamFrequentWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpamFrequentWords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHamWordLength;
        private System.Windows.Forms.Label labelHamAverageLength;
        private System.Windows.Forms.Label labelSpamAverageLength;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpamWordLength;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpamNoticeLength;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHamNoticeLength;
        private System.Windows.Forms.Label labelHamNoticeAvgLength;
        private System.Windows.Forms.Label labelSpamNoticeAvgLength;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHamFrequentWords;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpamFrequentWords;
    }
}

