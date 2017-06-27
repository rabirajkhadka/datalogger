namespace Datalogger
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.temperature = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.time_show = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.date_show = new System.Windows.Forms.Label();
            this.menubar = new System.Windows.Forms.MenuStrip();
            this.VIEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneDayReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneWeekReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportbugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.temp_label = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.menubar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // temperature
            // 
            this.temperature.Location = new System.Drawing.Point(180, 363);
            this.temperature.Name = "temperature";
            this.temperature.ReadOnly = true;
            this.temperature.Size = new System.Drawing.Size(66, 20);
            this.temperature.TabIndex = 1;
            this.temperature.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(28, 61);
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Size = new System.Drawing.Size(298, 31);
            this.title.TabIndex = 2;
            this.title.Text = "Temperature Data Logging";
            this.title.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // time_show
            // 
            this.time_show.AutoSize = true;
            this.time_show.Location = new System.Drawing.Point(297, 31);
            this.time_show.Name = "time_show";
            this.time_show.Size = new System.Drawing.Size(26, 13);
            this.time_show.TabIndex = 5;
            this.time_show.Text = "time";
            this.time_show.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // date_show
            // 
            this.date_show.AutoSize = true;
            this.date_show.Location = new System.Drawing.Point(7, 31);
            this.date_show.Name = "date_show";
            this.date_show.Size = new System.Drawing.Size(28, 13);
            this.date_show.TabIndex = 7;
            this.date_show.Text = "date";
            // 
            // menubar
            // 
            this.menubar.Dock = System.Windows.Forms.DockStyle.None;
            this.menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VIEWToolStripMenuItem,
            this.HELPToolStripMenuItem});
            this.menubar.Location = new System.Drawing.Point(3, 2);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(101, 24);
            this.menubar.Stretch = false;
            this.menubar.TabIndex = 8;
            this.menubar.Text = "menu_bar";
            // 
            // VIEWToolStripMenuItem
            // 
            this.VIEWToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oneDayReportToolStripMenuItem,
            this.oneWeekReportToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem";
            this.VIEWToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.VIEWToolStripMenuItem.Text = "VIEW";
            // 
            // oneDayReportToolStripMenuItem
            // 
            this.oneDayReportToolStripMenuItem.Name = "oneDayReportToolStripMenuItem";
            this.oneDayReportToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.oneDayReportToolStripMenuItem.Text = "One day Report";
            this.oneDayReportToolStripMenuItem.Click += new System.EventHandler(this.oneDayReportToolStripMenuItem_Click);
            // 
            // oneWeekReportToolStripMenuItem
            // 
            this.oneWeekReportToolStripMenuItem.Name = "oneWeekReportToolStripMenuItem";
            this.oneWeekReportToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.oneWeekReportToolStripMenuItem.Text = "Multipe day Report";
            this.oneWeekReportToolStripMenuItem.Click += new System.EventHandler(this.oneWeekReportToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            this.databaseToolStripMenuItem.Click += new System.EventHandler(this.databaseToolStripMenuItem_Click);
            // 
            // HELPToolStripMenuItem
            // 
            this.HELPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.reportbugToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem";
            this.HELPToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.HELPToolStripMenuItem.Text = "HELP";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // reportbugToolStripMenuItem
            // 
            this.reportbugToolStripMenuItem.Name = "reportbugToolStripMenuItem";
            this.reportbugToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.reportbugToolStripMenuItem.Text = "Report a Bug";
            this.reportbugToolStripMenuItem.Click += new System.EventHandler(this.reportbugToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            this.checkForUpdatesToolStripMenuItem.Visible = false;
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 24);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 24);
            this.panel2.TabIndex = 11;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "All right reserved @ sanrajinfosys pvt. ltd.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "All right reserved @ sanrajinfosys pvt. ltd.";
            // 
            // temp_label
            // 
            this.temp_label.AutoSize = true;
            this.temp_label.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp_label.Location = new System.Drawing.Point(10, 361);
            this.temp_label.Name = "temp_label";
            this.temp_label.Size = new System.Drawing.Size(164, 23);
            this.temp_label.TabIndex = 1161;
            this.temp_label.Text = "Current Temperature :";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit.Location = new System.Drawing.Point(335, -1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(29, 28);
            this.exit.TabIndex = 1158;
            this.exit.Text = "X";
            this.exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave_1);
            this.exit.MouseHover += new System.EventHandler(this.exit_MouseHover_1);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minimize.Location = new System.Drawing.Point(308, -1);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(29, 28);
            this.minimize.TabIndex = 1157;
            this.minimize.Text = "_";
            this.minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            this.minimize.MouseLeave += new System.EventHandler(this.minimize_MouseLeave);
            this.minimize.MouseHover += new System.EventHandler(this.minimize_MouseHover_1);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_main.Controls.Add(this.minimize);
            this.panel_main.Controls.Add(this.exit);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(364, 27);
            this.panel_main.TabIndex = 1160;
            this.panel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseDown);
            this.panel_main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseMove);
            this.panel_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseUp);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(364, 423);
            this.Controls.Add(this.temp_label);
            this.Controls.Add(this.date_show);
            this.Controls.Add(this.time_show);
            this.Controls.Add(this.title);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.menubar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menubar;
            this.MaximizeBox = false;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Data Logging";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox temperature;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label time_show;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label date_show;
        private System.Windows.Forms.MenuStrip menubar;
        private System.Windows.Forms.ToolStripMenuItem VIEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oneDayReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oneWeekReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HELPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportbugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label temp_label;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Panel panel_main;
    }
}

