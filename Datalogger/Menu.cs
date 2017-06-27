using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using MySql.Data.MySqlClient;
using System.IO.Ports;


namespace Datalogger
{
    public partial class menu : Form
    {
        public SerialPort myport;
        private string data;
        public menu()
        {
            InitializeComponent();
            serialread();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            
            
        }
        public void serialread()
        {
            myport = new SerialPort();
            myport.BaudRate = 115200;
            myport.PortName = "COM3";
            myport.Parity = Parity.None;
            myport.DataBits = 8;
            myport.StopBits = StopBits.One;
            try
            {
                myport.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myport.DataReceived += myport_DataReceived;
           
        }
        void myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            try
            {
                this.Invoke(new EventHandler(display_event));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void display_event(object sender, EventArgs e)
        {
            
            data = myport.ReadLine();
            temperature.Text=data.Substring(data.Length-6,5);
            try
            {
                String path = @"C:\Users\RabIraj\Desktop\";
                String filename = "data.csv";
                //System.IO.File.AppendAllText(path + filename, time + "\t" + readdata + "\n");
                System.IO.File.AppendAllText(path + filename, data + "\n");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
       
       
        private void Form1_Load(object sender, EventArgs e)
        {
           /* //initialize class level bitmaps
            img = Properties.Resources.tempscalessmall;
            bar = Properties.Resources.bar;
            //make Color.White transparent in bar image
            bar.MakeTransparent(Color.White);
            */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myport.Close();
            this.Hide();
            second_layout secondl = new second_layout();
            secondl.ShowDialog();
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_show.Text = DateTime.Now.ToLongTimeString();
            date_show.Text = DateTime.Now.ToLongDateString();


        }

        

        private void menu_FormClosing(object sender, FormClosingEventArgs e)
        {

          /*  DialogResult dialog = MessageBox.Show("Do you really want to close datalogger?", "Exit", MessageBoxButtons.YesNo  );
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
           * */
        }

        private void aboutUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            myport.Close();
            AboutUs abtus = new AboutUs();
            //this.Hide();
            abtus.ShowDialog();
            
        }

        private void oneDayReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myport.Close();
            this.Hide();
            second_layout secondl = new second_layout();
            secondl.ShowDialog();
            
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            
             DialogResult dialog = MessageBox.Show("Do you really want to close datalogger?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
             

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

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void temp_indicator_Click(object sender, EventArgs e)
        {

        }

        private void temp_indicator_ValueChanged(object sender, EventArgs e)
        {

        }

        private void temp_indicator_MouseHover(object sender, EventArgs e)
        {

        }

        private void oneWeekReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myport.Close();
            this.Hide();
            selectdatetwo second2 = new selectdatetwo();
            second2.ShowDialog();
            
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Under Construction");
            myport.Close();
            reportshow gen = new reportshow("all available",1);
            gen.ShowDialog();
            

        }

        private void reportbugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myport.Close();
            BugAttach sendbug = new BugAttach();
            sendbug.ShowDialog();
            
        }

        

    }
}
