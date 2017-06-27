namespace Datalogger
{
    partial class second_layout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(second_layout));
            this.generateone = new System.Windows.Forms.Button();
            this.dateselectup_panel = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.dateselectdown_panel = new System.Windows.Forms.Panel();
            this.selectdate = new System.Windows.Forms.Button();
            this.onedate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dateselectup_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // generateone
            // 
            this.generateone.Location = new System.Drawing.Point(330, 53);
            this.generateone.Name = "generateone";
            this.generateone.Size = new System.Drawing.Size(75, 23);
            this.generateone.TabIndex = 2;
            this.generateone.Text = "Generate";
            this.generateone.UseVisualStyleBackColor = true;
            this.generateone.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateselectup_panel
            // 
            this.dateselectup_panel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dateselectup_panel.Controls.Add(this.pictureBox3);
            this.dateselectup_panel.Controls.Add(this.title);
            this.dateselectup_panel.Controls.Add(this.minimize);
            this.dateselectup_panel.Controls.Add(this.exit);
            this.dateselectup_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateselectup_panel.Location = new System.Drawing.Point(0, 0);
            this.dateselectup_panel.Name = "dateselectup_panel";
            this.dateselectup_panel.Size = new System.Drawing.Size(412, 28);
            this.dateselectup_panel.TabIndex = 3;
            this.dateselectup_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseDown);
            this.dateselectup_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseMove);
            this.dateselectup_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseUp);
            // 
            // title
            // 
            this.title.FlatAppearance.BorderSize = 0;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.title.Location = new System.Drawing.Point(22, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(149, 28);
            this.title.TabIndex = 1160;
            this.title.Text = "Date Selection";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.title.UseVisualStyleBackColor = false;
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseMove);
            this.title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseUp);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minimize.Location = new System.Drawing.Point(354, -1);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(30, 30);
            this.minimize.TabIndex = 1158;
            this.minimize.Text = "_";
            this.minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit.Location = new System.Drawing.Point(382, -1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(30, 30);
            this.exit.TabIndex = 1157;
            this.exit.Text = "X";
            this.exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // dateselectdown_panel
            // 
            this.dateselectdown_panel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dateselectdown_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dateselectdown_panel.Location = new System.Drawing.Point(0, 82);
            this.dateselectdown_panel.Name = "dateselectdown_panel";
            this.dateselectdown_panel.Size = new System.Drawing.Size(412, 28);
            this.dateselectdown_panel.TabIndex = 4;
            this.dateselectdown_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseDown);
            this.dateselectdown_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseMove);
            this.dateselectdown_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseUp);
            // 
            // selectdate
            // 
            this.selectdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selectdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.selectdate.Location = new System.Drawing.Point(12, 35);
            this.selectdate.Name = "selectdate";
            this.selectdate.Size = new System.Drawing.Size(75, 23);
            this.selectdate.TabIndex = 7;
            this.selectdate.Text = "select date";
            this.selectdate.UseVisualStyleBackColor = false;
            // 
            // onedate
            // 
            this.onedate.Location = new System.Drawing.Point(93, 37);
            this.onedate.Name = "onedate";
            this.onedate.Size = new System.Drawing.Size(200, 20);
            this.onedate.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(1, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 1161;
            this.pictureBox3.TabStop = false;
            // 
            // second_layout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 110);
            this.Controls.Add(this.onedate);
            this.Controls.Add(this.selectdate);
            this.Controls.Add(this.generateone);
            this.Controls.Add(this.dateselectdown_panel);
            this.Controls.Add(this.dateselectup_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "second_layout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report_view";
            this.Load += new System.EventHandler(this.second_layout_Load);
            this.dateselectup_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generateone;
        private System.Windows.Forms.Panel dateselectup_panel;
        private System.Windows.Forms.Panel dateselectdown_panel;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button exit;
        public System.Windows.Forms.Button selectdate;
        private System.Windows.Forms.Button title;
        private System.Windows.Forms.DateTimePicker onedate;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}