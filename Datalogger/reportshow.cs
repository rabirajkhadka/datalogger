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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms.DataVisualization.Charting;

namespace Datalogger
{
    public partial class reportshow : Form
    {
        private bool onedate;
        private bool twodate;
        private bool alldate;
        private String dtt;
        private string do1;
        private string do2;


        public reportshow()
        {
            InitializeComponent();
            //loadchart();
            description_Text();
            
        }
        public reportshow(DateTime dt)
        {
            InitializeComponent();
            do1 = dt.ToShortDateString();
            loadchart(dt.ToShortDateString());
            onedate = true; twodate = false; alldate = false;
            show_selectdate.Text = dt.ToShortDateString();
            data_field(dt);
            description_Text();
        }
        public reportshow(DateTime d1,DateTime d2)
        {
            InitializeComponent();
            do1 = d1.ToShortDateString();
            do2 = d2.ToShortDateString();
            loadchart(d1.ToShortDateString(),d2.ToShortDateString());
            onedate = false; twodate = true; alldate = false;
            show_selectdate.Text = d1.ToShortDateString() + " \t to \t " + d2.ToShortDateString();
            data_field(d1, d2);
            description_Text();
        }
        public reportshow(string message,int stat)
        {
            InitializeComponent();
            loadchart();
            onedate = false; twodate = false; alldate = true;
            if (stat == 1)
            {
                show_selectdate.Text = " Selected Date: " + message;
            }
            data_field(message, stat);
            description_Text();
        }
        public void loadchart(String one)
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

        public void loadchart(String one, String two)
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
        
        public void loadchart()
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
               
        public void data_field(DateTime dt)
        {
            string connection = "datasource=127.0.0.1;port=3306;username=rabIraj;password=robotic$";
            MySqlConnection myconn = new MySqlConnection(connection);
            dtt = dt.ToShortDateString();

          //  MessageBox.Show(dtt);

            MySqlCommand cmdDataBase = new MySqlCommand(" select * from projectdatalogger.records where date = '" + dtt + "' ;", myconn);
            try
            {
                MySqlDataAdapter adapt = new MySqlDataAdapter();
                adapt.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                adapt.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                viewdata.DataSource = bSource;
                adapt.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void data_field(DateTime d1, DateTime d2)
        {

            string connection = "datasource=127.0.0.1;port=3306;username=rabIraj;password=robotic$";
            MySqlConnection myconn = new MySqlConnection(connection);
            String dt1 = d1.ToShortDateString();
            String dt2 = d2.ToShortDateString();

            MySqlCommand cmdDataBase = new MySqlCommand(" select * from projectdatalogger.records where date BETWEEN '"+dt1 + "' AND '"+dt2+"';", myconn);
            try
            {
                MySqlDataAdapter adapt = new MySqlDataAdapter();
                adapt.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                adapt.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                viewdata.DataSource = bSource;
                adapt.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void data_field(string argu, int stat)
        {
            string connection = "datasource=127.0.0.1;port=3306;username=rabIraj;password=robotic$";
            MySqlConnection myconn = new MySqlConnection(connection);
            
            MySqlCommand cmdDataBase = new MySqlCommand(" select * from projectdatalogger.records order by date asc ;", myconn);
            try
            {
                MySqlDataAdapter adapt = new MySqlDataAdapter();
                adapt.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                adapt.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                viewdata.DataSource = bSource;
                adapt.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void reportshow_Load(object sender, EventArgs e)
        {

        }

        private void viewdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menuback = new menu();
            menuback.ShowDialog();
            //Application.Exit();

        }

        private void minimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void panelmain_MouseUp(object sender, MouseEventArgs e)
        {

            mouseDown = false;
        }

        private void load_Click(object sender, EventArgs e)
        {
            
           /* testchart main = new testchart("7/18/2015");
            main.ShowDialog();*/
        
        }

        private void description_TextChanged(object sender, EventArgs e)
        {

        }

        private void description_Text()
        {
            
            try
            {
                int Counter = 0;
                double AverageCalc = 0;
                double min = Convert.ToDouble(viewdata.Rows[0].Cells[2].Value.ToString());
                double max = Convert.ToDouble(viewdata.Rows[0].Cells[2].Value.ToString());
                while (Counter < viewdata.Rows.Count)
                {
                    string Average = null;                
                    Average = viewdata.Rows[Counter].Cells[2].Value.ToString();
                    if (min > Convert.ToDouble(viewdata.Rows[Counter].Cells[2].Value.ToString()))
                    {
                        min = Convert.ToDouble(viewdata.Rows[Counter].Cells[2].Value.ToString());
                    }
                    if (max < Convert.ToDouble(viewdata.Rows[Counter].Cells[2].Value.ToString()))
                    {
                        max = Convert.ToDouble(viewdata.Rows[Counter].Cells[2].Value.ToString());
                    }
                    AverageCalc = AverageCalc + Convert.ToDouble(Average);
                    
                    Counter++;
                }
                AverageCalc = AverageCalc / viewdata.Rows.Count;
                description.Text = "Minimum Temperature and Maximum Temperature obtained from the selected date(" + show_selectdate.Text + ") is " + min.ToString() + " and " + max.ToString() + " respectively and Average Temperature is " +Convert.ToDouble(AverageCalc).ToString()+" . Total Number of data for selected date is "+ viewdata.Rows.Count.ToString();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
           

            
            /*
             * var MaxID = viewdata.Rows.Cast<DataGridViewRow>().Max(r => r.Cells["temperature"].Value);
             * description.Text= MaxID.ToString();
             */

               // description.Text = (from DataGridViewRow row in viewdata.Rows  where row.Cells[2].FormattedValue.ToString() !=string.Empty select Convert.ToInt32(row.Cells[2].FormattedValue)).Max().ToString();

        }

        private void saveIntoPdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                String path = "C:\\Users\\RabIraj\\Desktop\\";
                String filename = show_selectdate.Text + ".pdf";
                filename = filename.Replace("/","_");
                Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);
                PdfWriter write = PdfWriter.GetInstance(doc, new FileStream( path + filename, FileMode.Create));
                doc.Open();

                PdfPTable table = new PdfPTable(viewdata.Columns.Count);
                for (int j = 0; j < viewdata.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(viewdata.Columns[j].HeaderText));
                }
                table.HeaderRows = 1;

                for (int i = 0; i < viewdata.Rows.Count; i++)
                {
                    for (int k = 0; k < viewdata.Columns.Count; k++)
                    {
                        if (viewdata[k, i].Value != null)
                        {
                            table.AddCell(new Phrase(viewdata[k, i].Value.ToString()));
                        }
                    }
                }
                
                doc.Add(table);

                //below code to add chart
                var chartimage = new MemoryStream();
                chart1.SaveImage(chartimage,ChartImageFormat.Png);
                iTextSharp.text.Image Chart_Image = iTextSharp.text.Image.GetInstance(chartimage.GetBuffer());
                doc.Add(Chart_Image);
                
                //below code to add description paragraph
                Paragraph paragraph = new Paragraph(description.Text);
                doc.Add(paragraph);
                doc.Close();
                
                MessageBox.Show("File Saved @ " + path+filename);
                

                /*   Document doc = new Document (iTextSharp.text.PageSize.A4,10,10,42,35);
                   PdfWriter write = PdfWriter.GetInstance(doc,new FileStream(path+filename,FileMode.Create));
                   doc.Open();
                   Paragraph paragraph = new Paragraph(description.Text);
                   doc.Add(paragraph);
                   doc.Close();
                */
            }
            catch (Exception em)
            {
                MessageBox.Show(em.Message);
            }
        }

        private void viewChartOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (onedate == true)
            {
                testchart main = new testchart(do1);
                main.ShowDialog();
            }
            if (twodate == true)
            {
                testchart main = new testchart(do1,do2);
                main.ShowDialog();
            }
            if (alldate == true)
            {
                testchart main = new testchart();
                main.ShowDialog();
            }
            
       }
        
    }
}
