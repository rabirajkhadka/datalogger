﻿namespace Datalogger
{
    partial class selectdatetwo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selectdatetwo));
            this.dateselectdown_panel = new System.Windows.Forms.Panel();
            this.twodate1 = new System.Windows.Forms.DateTimePicker();
            this.dateselectup_panel = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Button();
            this.twodate2 = new System.Windows.Forms.DateTimePicker();
            this.generatetwo = new System.Windows.Forms.Button();
            this.selectdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dateselectup_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dateselectdown_panel
            // 
            this.dateselectdown_panel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dateselectdown_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dateselectdown_panel.Location = new System.Drawing.Point(0, 97);
            this.dateselectdown_panel.Name = "dateselectdown_panel";
            this.dateselectdown_panel.Size = new System.Drawing.Size(482, 28);
            this.dateselectdown_panel.TabIndex = 5;
            this.dateselectdown_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseDown);
            this.dateselectdown_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseMove);
            this.dateselectdown_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseUp);
            // 
            // twodate1
            // 
            this.twodate1.Location = new System.Drawing.Point(41, 45);
            this.twodate1.Name = "twodate1";
            this.twodate1.Size = new System.Drawing.Size(200, 20);
            this.twodate1.TabIndex = 0;
            // 
            // dateselectup_panel
            // 
            this.dateselectup_panel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dateselectup_panel.Controls.Add(this.pictureBox3);
            this.dateselectup_panel.Controls.Add(this.minimize);
            this.dateselectup_panel.Controls.Add(this.exit);
            this.dateselectup_panel.Controls.Add(this.title);
            this.dateselectup_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateselectup_panel.Location = new System.Drawing.Point(0, 0);
            this.dateselectup_panel.Name = "dateselectup_panel";
            this.dateselectup_panel.Size = new System.Drawing.Size(482, 28);
            this.dateselectup_panel.TabIndex = 6;
            this.dateselectup_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseDown);
            this.dateselectup_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseMove);
            this.dateselectup_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelmain_MouseUp);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minimize.Location = new System.Drawing.Point(424, -2);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(30, 30);
            this.minimize.TabIndex = 1158;
            this.minimize.Text = "_";
            this.minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            this.minimize.MouseLeave += new System.EventHandler(this.minimize_MouseLeave);
            this.minimize.MouseHover += new System.EventHandler(this.minimize_MouseHover_1);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit.Location = new System.Drawing.Point(452, -2);
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
            // title
            // 
            this.title.FlatAppearance.BorderSize = 0;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.title.Location = new System.Drawing.Point(24, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(211, 28);
            this.title.TabIndex = 1159;
            this.title.Text = "Date Selection";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.title.UseVisualStyleBackColor = false;
            // 
            // twodate2
            // 
            this.twodate2.Location = new System.Drawing.Point(268, 45);
            this.twodate2.Name = "twodate2";
            this.twodate2.Size = new System.Drawing.Size(200, 20);
            this.twodate2.TabIndex = 7;
            // 
            // generatetwo
            // 
            this.generatetwo.Location = new System.Drawing.Point(404, 71);
            this.generatetwo.Name = "generatetwo";
            this.generatetwo.Size = new System.Drawing.Size(75, 23);
            this.generatetwo.TabIndex = 10;
            this.generatetwo.Text = "Generate";
            this.generatetwo.UseVisualStyleBackColor = true;
            this.generatetwo.Click += new System.EventHandler(this.generatetwo_Click);
            // 
            // selectdate
            // 
            this.selectdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selectdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.selectdate.Location = new System.Drawing.Point(6, 44);
            this.selectdate.Name = "selectdate";
            this.selectdate.Size = new System.Drawing.Size(35, 20);
            this.selectdate.TabIndex = 11;
            this.selectdate.Text = "from";
            this.selectdate.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(242, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 20);
            this.button1.TabIndex = 12;
            this.button1.Text = "to";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(1, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 1160;
            this.pictureBox3.TabStop = false;
            // 
            // selectdatetwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 125);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectdate);
            this.Controls.Add(this.generatetwo);
            this.Controls.Add(this.twodate2);
            this.Controls.Add(this.dateselectup_panel);
            this.Controls.Add(this.twodate1);
            this.Controls.Add(this.dateselectdown_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "selectdatetwo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "selectdatetwo";
            this.dateselectup_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dateselectdown_panel;
        private System.Windows.Forms.DateTimePicker twodate1;
        private System.Windows.Forms.Panel dateselectup_panel;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.DateTimePicker twodate2;
        private System.Windows.Forms.Button generatetwo;
        private System.Windows.Forms.Button title;
        public System.Windows.Forms.Button selectdate;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}