namespace Datalogger
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.sign_in = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.uesr_id = new System.Windows.Forms.Label();
            this.user_pwd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login_img = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.up_panel = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.downpanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.signup = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.login_img)).BeginInit();
            this.up_panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sign_in
            // 
            resources.ApplyResources(this.sign_in, "sign_in");
            this.sign_in.Name = "sign_in";
            this.sign_in.UseVisualStyleBackColor = true;
            this.sign_in.Click += new System.EventHandler(this.sign_in_Click);
            // 
            // username
            // 
            resources.ApplyResources(this.username, "username");
            this.username.Name = "username";
            // 
            // pwd
            // 
            resources.ApplyResources(this.pwd, "pwd");
            this.pwd.Name = "pwd";
            // 
            // uesr_id
            // 
            resources.ApplyResources(this.uesr_id, "uesr_id");
            this.uesr_id.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uesr_id.Name = "uesr_id";
            // 
            // user_pwd
            // 
            resources.ApplyResources(this.user_pwd, "user_pwd");
            this.user_pwd.Name = "user_pwd";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // login_img
            // 
            resources.ApplyResources(this.login_img, "login_img");
            this.login_img.Name = "login_img";
            this.login_img.TabStop = false;
            this.login_img.Click += new System.EventHandler(this.login_img_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.exit, "exit");
            this.exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exit.Name = "exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            this.exit.MouseHover += new System.EventHandler(this.exit_MouseHover);
            // 
            // up_panel
            // 
            this.up_panel.BackColor = System.Drawing.SystemColors.GrayText;
            this.up_panel.Controls.Add(this.pictureBox1);
            this.up_panel.Controls.Add(this.title);
            this.up_panel.Controls.Add(this.minimize);
            this.up_panel.Controls.Add(this.exit);
            resources.ApplyResources(this.up_panel, "up_panel");
            this.up_panel.Name = "up_panel";
            this.up_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.up_panel_MouseDown);
            this.up_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.up_panel_MouseMove);
            this.up_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.up_panel_MouseUp);
            // 
            // title
            // 
            resources.ApplyResources(this.title, "title");
            this.title.FlatAppearance.BorderSize = 0;
            this.title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title.Name = "title";
            this.title.UseVisualStyleBackColor = false;
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.minimize, "minimize");
            this.minimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minimize.Name = "minimize";
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            this.minimize.MouseLeave += new System.EventHandler(this.minimize_MouseLeave);
            this.minimize.MouseHover += new System.EventHandler(this.minimize_MouseHover);
            // 
            // downpanel
            // 
            this.downpanel.BackColor = System.Drawing.SystemColors.GrayText;
            resources.ApplyResources(this.downpanel, "downpanel");
            this.downpanel.Name = "downpanel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.user_pwd);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.pwd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.uesr_id);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // signup
            // 
            this.signup.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.signup, "signup");
            this.signup.Name = "signup";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AcceptButton = this.sign_in;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.signup);
            this.Controls.Add(this.downpanel);
            this.Controls.Add(this.up_panel);
            this.Controls.Add(this.login_img);
            this.Controls.Add(this.sign_in);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.login_img)).EndInit();
            this.up_panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sign_in;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Label uesr_id;
        private System.Windows.Forms.Label user_pwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox login_img;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel up_panel;
        private System.Windows.Forms.Panel downpanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button title;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}