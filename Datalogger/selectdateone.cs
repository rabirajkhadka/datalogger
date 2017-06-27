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
    public partial class second_layout : Form
    {
        public second_layout()
        {
            InitializeComponent();
        }

        private void second_layout_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            reportshow gen = new reportshow(onedate.Value);
            gen.ShowDialog();
              
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Application.Exit();
       
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
