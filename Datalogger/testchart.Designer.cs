namespace Datalogger
{
    partial class testchart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testchart));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.temp_box = new System.Windows.Forms.PictureBox();
            this.time_box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_box)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "temperature";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1008, 729);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // temp_box
            // 
            this.temp_box.Image = ((System.Drawing.Image)(resources.GetObject("temp_box.Image")));
            this.temp_box.Location = new System.Drawing.Point(13, 34);
            this.temp_box.Margin = new System.Windows.Forms.Padding(4);
            this.temp_box.Name = "temp_box";
            this.temp_box.Size = new System.Drawing.Size(27, 481);
            this.temp_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.temp_box.TabIndex = 11;
            this.temp_box.TabStop = false;
            // 
            // time_box
            // 
            this.time_box.Image = ((System.Drawing.Image)(resources.GetObject("time_box.Image")));
            this.time_box.Location = new System.Drawing.Point(706, 703);
            this.time_box.Name = "time_box";
            this.time_box.Size = new System.Drawing.Size(120, 31);
            this.time_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.time_box.TabIndex = 13;
            this.time_box.TabStop = false;
            // 
            // testchart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.time_box);
            this.Controls.Add(this.temp_box);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "testchart";
            this.Text = "GraphOnly";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.testchart_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.testchart_FormClosed);
            this.Load += new System.EventHandler(this.testchart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox temp_box;
        private System.Windows.Forms.PictureBox time_box;
    }
}