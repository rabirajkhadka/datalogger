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
    public partial class testchart : Form
    {
        public testchart(String one)
        {
            InitializeComponent();
            load(one);
        }
        public testchart(String one,String two)
        {
            InitializeComponent();
            load(one,two);
        }
        public testchart()
        {
            InitializeComponent();
            load();
        }
        private void testchart_Load(object sender, EventArgs e)
        {
        }
        public void load(String one)
        {
        string connection = "datasource=127.0.0.1;port=3306;username=rabIraj;password=robotic$";
            MySqlConnection myconn = new MySqlConnection(connection);
            MySqlCommand cmdDataBase = new MySqlCommand(" select * from projectdatalogger.records where date = '" + one + "' ;", myconn);
            MySqlDataReader read;

            try
            {
                myconn.Open();
                read = cmdDataBase.ExecuteReader();
                
                while (read.Read())
                {
                   this.chart1.Series["temperature"].Points.AddXY(read.GetString("time"), read.GetDecimal("temperature"));
                }            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void load(String one, String two)
        {

            string connection = "datasource=127.0.0.1;port=3306;username=rabIraj;password=robotic$";
            MySqlConnection myconn = new MySqlConnection(connection);
            MySqlCommand cmdDataBase = new MySqlCommand(" select * from projectdatalogger.records where date BETWEEN '" + one + "' AND '" + two + "';", myconn);
            MySqlDataReader read;

            try
            {
                myconn.Open();
                read = cmdDataBase.ExecuteReader();

                while (read.Read())
                {
                    this.chart1.Series["temperature"].Points.AddXY(read.GetString("time"), read.GetDecimal("temperature"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void load()
        {

            string connection = "datasource=127.0.0.1;port=3306;username=rabIraj;password=robotic$";
            MySqlConnection myconn = new MySqlConnection(connection);
            MySqlCommand cmdDataBase = new MySqlCommand(" select * from projectdatalogger.records;", myconn);
            MySqlDataReader read;

            try
            {
                myconn.Open();
                read = cmdDataBase.ExecuteReader();

                while (read.Read())
                {
                    this.chart1.Series["temperature"].Points.AddXY(read.GetString("time"), read.GetDecimal("temperature"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void testchart_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            menu back2menu = new menu();
            back2menu.ShowDialog();

        }

        private void testchart_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Return to main menu");
        }
        }

    }
