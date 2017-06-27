namespace Datalogger
{
    partial class reportshow
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reportshow));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.show_selectdate = new System.Windows.Forms.TextBox();
            this.rightclk = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveIntoPdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewChartOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showselecteddate = new System.Windows.Forms.Label();
            this.viewdata = new System.Windows.Forms.DataGridView();
            this.GB_temp = new System.Windows.Forms.GroupBox();
            this.dateselectup_panel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.dateselectdown_panel = new System.Windows.Forms.Panel();
            this.copyright = new System.Windows.Forms.Label();
            this.load = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.description = new System.Windows.Forms.TextBox();
            this.rightclk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewdata)).BeginInit();
            this.GB_temp.SuspendLayout();
            this.dateselectup_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.dateselectdown_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // show_selectdate
            // 
            this.show_selectdate.ContextMenuStrip = this.rightclk;
            this.show_selectdate.Cursor = System.Windows.Forms.Cursors.No;
            this.show_selectdate.Location = new System.Drawing.Point(91, 42);
            this.show_selectdate.Name = "show_selectdate";
            this.show_selectdate.ReadOnly = true;
            this.show_selectdate.Size = new System.Drawing.Size(317, 20);
            this.show_selectdate.TabIndex = 0;
            this.show_selectdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rightclk
            // 
            this.rightclk.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveIntoPdfToolStripMenuItem,
            this.viewChartOnlyToolStripMenuItem});
            this.rightclk.Name = "rightclk";
            this.rightclk.Size = new System.Drawing.Size(155, 48);
            // 
            // saveIntoPdfToolStripMenuItem
            // 
            this.saveIntoPdfToolStripMenuItem.Name = "saveIntoPdfToolStripMenuItem";
            this.saveIntoPdfToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.saveIntoPdfToolStripMenuItem.Text = "Save into Pdf";
            this.saveIntoPdfToolStripMenuItem.Click += new System.EventHandler(this.saveIntoPdfToolStripMenuItem_Click);
            // 
            // viewChartOnlyToolStripMenuItem
            // 
            this.viewChartOnlyToolStripMenuItem.Name = "viewChartOnlyToolStripMenuItem";
            this.viewChartOnlyToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.viewChartOnlyToolStripMenuItem.Text = "view chart only";
            this.viewChartOnlyToolStripMenuItem.Click += new System.EventHandler(this.viewChartOnlyToolStripMenuItem_Click);
            // 
            // showselecteddate
            // 
            this.showselecteddate.AutoSize = true;
            this.showselecteddate.ContextMenuStrip = this.rightclk;
            this.showselecteddate.Location = new System.Drawing.Point(12, 45);
            this.showselecteddate.Name = "showselecteddate";
            this.showselecteddate.Size = new System.Drawing.Size(74, 13);
            this.showselecteddate.TabIndex = 1;
            this.showselecteddate.Text = "selected date:";
            // 
            // viewdata
            // 
            this.viewdata.AllowUserToAddRows = false;
            this.viewdata.AllowUserToDeleteRows = false;
            this.viewdata.AllowUserToResizeColumns = false;
            this.viewdata.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.viewdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewdata.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.viewdata.BackgroundColor = System.Drawing.Color.White;
            this.viewdata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viewdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.viewdata.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.viewdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewdata.ContextMenuStrip = this.rightclk;
            this.viewdata.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewdata.DefaultCellStyle = dataGridViewCellStyle3;
            this.viewdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewdata.EnableHeadersVisualStyles = false;
            this.viewdata.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.viewdata.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.viewdata.Location = new System.Drawing.Point(3, 16);
            this.viewdata.MultiSelect = false;
            this.viewdata.Name = "viewdata";
            this.viewdata.ReadOnly = true;
            this.viewdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.viewdata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.viewdata.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.viewdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.viewdata.ShowEditingIcon = false;
            this.viewdata.Size = new System.Drawing.Size(397, 594);
            this.viewdata.TabIndex = 2;
            this.viewdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewdata_CellContentClick);
            // 
            // GB_temp
            // 
            this.GB_temp.Controls.Add(this.viewdata);
            this.GB_temp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GB_temp.Location = new System.Drawing.Point(15, 68);
            this.GB_temp.Name = "GB_temp";
            this.GB_temp.Size = new System.Drawing.Size(403, 613);
            this.GB_temp.TabIndex = 3;
            this.GB_temp.TabStop = false;
            this.GB_temp.Text = "recorded temperature";
            // 
            // dateselectup_panel
            // 
            this.dateselectup_panel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dateselectup_panel.ContextMenuStrip = this.rightclk;
            this.dateselectup_panel.Controls.Add(this.pictureBox3);
            this.dateselectup_panel.Controls.Add(this.title);
            this.dateselectup_panel.Controls.Add(this.minimize);
            this.dateselectup_panel.Controls.Add(this.exit);
            this.dateselectup_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateselectup_panel.Location = new System.Drawing.Point(0, 0);
            this.dateselectup_panel.Name = "dateselectup_panel";
            this.dateselectup_panel.Size = new System.Drawing.Size(1008, 32);
            this.dateselectup_panel.TabIndex = 5;
            this.dateselectup_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseDown);
            this.dateselectup_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseMove);
            this.dateselectup_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // title
            // 
            this.title.ContextMenuStrip = this.rightclk;
            this.title.FlatAppearance.BorderSize = 0;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.title.Location = new System.Drawing.Point(26, 2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(263, 28);
            this.title.TabIndex = 1161;
            this.title.Text = "Time and Temperature Details ";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.title.UseVisualStyleBackColor = false;
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minimize.Location = new System.Drawing.Point(949, 1);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(30, 30);
            this.minimize.TabIndex = 1158;
            this.minimize.Text = "_";
            this.minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click_1);
            this.minimize.MouseLeave += new System.EventHandler(this.minimize_MouseLeave);
            this.minimize.MouseHover += new System.EventHandler(this.minimize_MouseHover_1);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit.Location = new System.Drawing.Point(978, 1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(30, 30);
            this.exit.TabIndex = 1157;
            this.exit.Text = "X";
            this.exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave_1);
            this.exit.MouseHover += new System.EventHandler(this.exit_MouseHover_1);
            // 
            // dateselectdown_panel
            // 
            this.dateselectdown_panel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dateselectdown_panel.ContextMenuStrip = this.rightclk;
            this.dateselectdown_panel.Controls.Add(this.copyright);
            this.dateselectdown_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dateselectdown_panel.Location = new System.Drawing.Point(0, 685);
            this.dateselectdown_panel.Name = "dateselectdown_panel";
            this.dateselectdown_panel.Size = new System.Drawing.Size(1008, 28);
            this.dateselectdown_panel.TabIndex = 6;
            this.dateselectdown_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseDown);
            this.dateselectdown_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseMove);
            this.dateselectdown_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseUp);
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.BackColor = System.Drawing.Color.DarkSlateGray;
            this.copyright.ContextMenuStrip = this.rightclk;
            this.copyright.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.Location = new System.Drawing.Point(388, 5);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(232, 19);
            this.copyright.TabIndex = 11;
            this.copyright.Text = "All right reserved @ sanrajinfosys pvt. ltd.";
            this.copyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.copyright.UseCompatibleTextRendering = true;
            // 
            // load
            // 
            this.load.Enabled = false;
            this.load.Location = new System.Drawing.Point(927, 656);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 7;
            this.load.Text = "LC";
            this.load.UseVisualStyleBackColor = true;
            this.load.Visible = false;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ContextMenuStrip = this.rightclk;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(426, 68);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.CustomProperties = "PixelPointWidth=1, DrawSideBySide=True, DrawingStyle=LightToDark, MinPixelPointWi" +
    "dth=1, PointWidth=1E-08, LabelStyle=Top, MaxPixelPointWidth=2";
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.Name = "temperature";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(575, 526);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Name = "Tempe";
            this.chart1.Titles.Add(title1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.rightclk;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(429, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ContextMenuStrip = this.rightclk;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(634, 575);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // description
            // 
            this.description.ContextMenuStrip = this.rightclk;
            this.description.Cursor = System.Windows.Forms.Cursors.No;
            this.description.Location = new System.Drawing.Point(429, 600);
            this.description.MaxLength = 327675;
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(572, 78);
            this.description.TabIndex = 4;
            this.description.TextChanged += new System.EventHandler(this.description_TextChanged);
            // 
            // reportshow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 713);
            this.ContextMenuStrip = this.rightclk;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.load);
            this.Controls.Add(this.dateselectdown_panel);
            this.Controls.Add(this.dateselectup_panel);
            this.Controls.Add(this.description);
            this.Controls.Add(this.showselecteddate);
            this.Controls.Add(this.show_selectdate);
            this.Controls.Add(this.GB_temp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "reportshow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Record";
            this.Load += new System.EventHandler(this.reportshow_Load);
            this.rightclk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewdata)).EndInit();
            this.GB_temp.ResumeLayout(false);
            this.dateselectup_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.dateselectdown_panel.ResumeLayout(false);
            this.dateselectdown_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox show_selectdate;
        private System.Windows.Forms.Label showselecteddate;
        private System.Windows.Forms.GroupBox GB_temp;
        public System.Windows.Forms.DataGridView viewdata;
        private System.Windows.Forms.Panel dateselectup_panel;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel dateselectdown_panel;
        private System.Windows.Forms.Button title;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem saveIntoPdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewChartOnlyToolStripMenuItem;
        private System.Windows.Forms.Label copyright;
        public System.Windows.Forms.TextBox description;
        public System.Windows.Forms.ContextMenuStrip rightclk;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}