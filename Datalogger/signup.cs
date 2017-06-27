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

namespace Datalogger
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
            password.PasswordChar = '*';
            confirm_password.PasswordChar = '*';
            password.MaxLength = 15;
            confirm_password.MaxLength = 15;
            

        }
        private String Gen;
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pwd_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialog = MessageBox.Show("Exit Without Signing UP?", "Exit", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    Application.Exit();
                }

            }
        }
        private void exit_MouseHover(object sender, EventArgs e)
        {
            this.exit.BackColor = Color.White;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            this.exit.BackColor = Color.Gray;
        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        private void panelmain_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panelmain_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;
                this.SetDesktopLocation(mouseX, mouseY);

            }
        }

        private void panelmain_MouseUp(object sender, MouseEventArgs e)
        {

            mouseDown = false;
        }
        private void M_CheckedChanged(object sender, EventArgs e)
        {
            Gen = "M";
        }

        private void F_CheckedChanged(object sender, EventArgs e)
        {
            Gen = "F";
        }
        private void signup_database_Click(object sender, EventArgs e)
        {

            if (String.Equals(password.Text, confirm_password.Text) && !(string.IsNullOrWhiteSpace(username.Text)) && !(string.IsNullOrWhiteSpace(password.Text)) && !(string.IsNullOrWhiteSpace(confirm_password.Text)) && !(string.IsNullOrWhiteSpace(mailid.Text)))
            {
                
                    string connection = "datasource=127.0.0.1;port=3306;username=rabIraj;password=robotic$"; 
                    MySqlConnection myconn = new MySqlConnection(connection);
                    MySqlCommand cmdDataBase = new MySqlCommand(" insert into projectdatalogger.user (fname,lname,Gender,uname,password,email,DOB) values('" + this.firstname.Text + "','" + this.lastname.Text + "','" + Gen + "','" + this.username.Text + "','" + this.password.Text + "','" + this.mailid.Text + "','" + this.dob.Value.ToShortDateString() + "') ;", myconn);
                    MySqlDataReader read;
                    try
                    {
                        myconn.Open();
                        read = cmdDataBase.ExecuteReader();
                        MessageBox.Show("You have been signed up!!! restarting application to login");
                        
                        while (read.Read())
                        {
                
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }       

            }
            else
            {
                MessageBox.Show("OOPS! Error Occured.\n Please fill all required field and check if password is matched ");
            }
            this.Hide();
            login signin = new login();
            signin.ShowDialog();

        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
