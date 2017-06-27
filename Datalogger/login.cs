using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
namespace Datalogger
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            pwd.PasswordChar = '*';
            pwd.MaxLength = 15;
        }

       

        private void sign_in_Click(object sender, EventArgs e)
        {

            string connection = "datasource=127.0.0.1;port=3306;username=rabIraj;password=robotic$";
            MySqlConnection myconn = new MySqlConnection(connection);
            MySqlCommand cmdDataBase = new MySqlCommand(" select * from projectdatalogger.user where uname ='"+this.username.Text+"' and password = '"+this.pwd.Text +"' ;", myconn);
            MySqlDataReader read;
            myconn.Open();
            read = cmdDataBase.ExecuteReader();
            int count=0;
            while (read.Read())
            {
                count = count + 1;
            
            }
            if (count == 1)
            {
                this.Hide();
                menu main = new menu();
                main.ShowDialog();

            }
            else
            {
                MessageBox.Show("Incorrect Login Credentials");
            }
            /*
            if ((String.Equals(username.Text, "r")) && (String.Equals(pwd.Text, "r")))
            {
                this.Hide();
                //MessageBox.Show("Redirecting to menu");
                menu main = new menu();
                main.ShowDialog();


            }
            else
            {
                if ((String.Equals(username.Text, "RabIraj")))
                {
                    MessageBox.Show("Password Mismatched\n Password retrieval not available");
                }
                else if ((String.Equals(pwd.Text, "robotics")))
                {
                    MessageBox.Show("Username Mismatched");
                }
                else
                {
                    MessageBox.Show("Username and Password Mismatched");
                }
            }

            */
        }

        private void login_img_Click(object sender, EventArgs e)
        {
            //trackBar1.Value = 5;	

        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close datalogger?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void exit_MouseHover(object sender, EventArgs e)
        {
            this.exit.BackColor = Color.White;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            this.exit.BackColor = Color.Gray;
        }

        private void minimize_MouseHover(object sender, EventArgs e)
        {
            this.minimize.BackColor = Color.White;
        }

        private void minimize_MouseLeave(object sender, EventArgs e)
        {
            this.minimize.BackColor = Color.Gray;
        }


        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        private void up_panel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void up_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;
                this.SetDesktopLocation(mouseX, mouseY);

            }
        }

        private void up_panel_MouseUp(object sender, MouseEventArgs e)
        {

            mouseDown = false;
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signup_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("This will proceed you to sign up page. :) ", "signup_process", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                signup newform = new signup();
                newform.ShowDialog();
            } 
        }

        

       
        
    }
}
