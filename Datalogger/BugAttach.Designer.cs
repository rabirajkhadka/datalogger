namespace Datalogger
{
    partial class BugAttach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BugAttach));
            this.mail_client = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.report_msg = new System.Windows.Forms.TextBox();
            this.mailadd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mail_client
            // 
            this.mail_client.Location = new System.Drawing.Point(120, 20);
            this.mail_client.Name = "mail_client";
            this.mail_client.Size = new System.Drawing.Size(100, 20);
            this.mail_client.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // report_msg
            // 
            this.report_msg.Location = new System.Drawing.Point(120, 71);
            this.report_msg.Multiline = true;
            this.report_msg.Name = "report_msg";
            this.report_msg.Size = new System.Drawing.Size(303, 157);
            this.report_msg.TabIndex = 1;
            // 
            // mailadd
            // 
            this.mailadd.AutoSize = true;
            this.mailadd.Location = new System.Drawing.Point(12, 20);
            this.mailadd.Name = "mailadd";
            this.mailadd.Size = new System.Drawing.Size(88, 13);
            this.mailadd.TabIndex = 2;
            this.mailadd.Text = "your mail address";
            // 
            // BugAttach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 332);
            this.Controls.Add(this.mailadd);
            this.Controls.Add(this.report_msg);
            this.Controls.Add(this.mail_client);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BugAttach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report a bug";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mail_client;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox report_msg;
        private System.Windows.Forms.Label mailadd;
    }
}