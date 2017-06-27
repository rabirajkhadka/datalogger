using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datalogger
{
    public partial class selectdatetwo : Form
    {
        public selectdatetwo()
        {
            InitializeComponent();
        }

        private void generatetwo_Click(object sender, EventArgs e)
        {
            int c1=twodate1.Value.CompareTo(twodate2.Value);
            //MessageBox.Show("a"+c1);
            if (c1==0)
            {
                MessageBox.Show("same date selected");
                this.Hide();
                reportshow gen = new reportshow(twodate1.Value);
                gen.ShowDialog();
                
            }
            else if(c1==1)
            {
                MessageBox.Show("Selected Date Are In Invalid Order\nPlease Select Date In Correct Order");
            }

            else
            {
               // MessageBox.Show("greater ok ");
                this.Hide();
                reportshow gen = new reportshow(twodate1.Value, twodate2.Value);
                gen.ShowDialog();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Application.Exit();
             
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void exit_MouseHover_1(object sender, EventArgs e)
        {
            this.exit.BackColor = Color.White;
        }

        private void exit_MouseLeave_1(object sender, EventArgs e)
        {
            this.exit.BackColor = Color.WhiteSmoke;
        }

        private void minimize_MouseHover_1(object sender, EventArgs e)
        {
            this.minimize.BackColor = Color.White;
        }

        private void minimize_MouseLeave(object sender, EventArgs e)
        {
            this.minimize.BackColor = Color.WhiteSmoke;
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

    }
}
