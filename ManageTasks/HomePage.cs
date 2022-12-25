using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ManageTasks
{
    public partial class HomePage : Form
    {
        Thread thread;
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            LoadPersonalChart();
            LoadCareerChart();
            LoadOtherChart();
          
         
        }

        private void LoadOtherChart()
        {
            DataTable table = new DataTable();
            string query = "select t.name,  count(case when a.type_id = 4 then 1 end), count(a.type_id) from Task t inner join MAP_How a on a.task_id= t.Id where t.type='other' group by t.name";
            table = DAL.dynamicTConnection(query);
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    //   MessageBox.Show(table.Rows[i].ItemArray[0].ToString()+"  "+table.Rows[i].ItemArray[1].ToString()+"   "+table.Rows[i].ItemArray[2].ToString());
                    float all = float.Parse(table.Rows[i].ItemArray[2].ToString());
                    float done = float.Parse(table.Rows[i].ItemArray[1].ToString());
                    float percentage = done / all;
                    percentage = percentage * 100;
                    //   MessageBox.Show(percentage.ToString());
                    other.Series[0].Points.AddXY(table.Rows[i].ItemArray[0].ToString(), (int)percentage);
                }
            }
            // Set the chart title
            this.other.Titles.Add("Time Management");
            // Set chart type like Bar chart, Pie chart 
            other.Series["Series1"].ChartType = SeriesChartType.Pie;
            // To show chart value           
            other.Series["Series1"].IsValueShownAsLabel = true;
        }

        private void LoadCareerChart()
        {
            DataTable table = new DataTable();
            string query = "select t.name,  count(case when a.type_id = 4 then 1 end), count(a.type_id) from Task t inner join MAP_How a on a.task_id= t.Id where t.type='career' group by t.name";
            table = DAL.dynamicTConnection(query);
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    //   MessageBox.Show(table.Rows[i].ItemArray[0].ToString()+"  "+table.Rows[i].ItemArray[1].ToString()+"   "+table.Rows[i].ItemArray[2].ToString());
                    float all = float.Parse(table.Rows[i].ItemArray[2].ToString());
                    float done = float.Parse(table.Rows[i].ItemArray[1].ToString());
                    float percentage = done / all;
                    percentage = percentage * 100;
                 //   MessageBox.Show(percentage.ToString());
                    career.Series[0].Points.AddXY(table.Rows[i].ItemArray[0].ToString(), (int)percentage);
                }
            }
            this.career.Titles.Add("Career Management");
            // Set chart type like Bar chart, Pie chart 
            career.Series["Series1"].ChartType = SeriesChartType.Pie;
            // To show chart value           
            career.Series["Series1"].IsValueShownAsLabel = true;
        }

        private void LoadPersonalChart()
        {
            DataTable table = new DataTable();
            string query = "select t.name,  count(case when a.type_id = 4 then 1 end), count(a.type_id) from Task t inner join MAP_How a on a.task_id= t.Id where t.type='personal' group by t.name";
            table = DAL.dynamicTConnection(query);
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                 //   MessageBox.Show(table.Rows[i].ItemArray[0].ToString()+"  "+table.Rows[i].ItemArray[1].ToString()+"   "+table.Rows[i].ItemArray[2].ToString());
                    float all =float.Parse(table.Rows[i].ItemArray[2].ToString());
                    float done = float.Parse(table.Rows[i].ItemArray[1].ToString());
                    float percentage = done / all;
                    percentage = percentage * 100;
                  //  MessageBox.Show(percentage.ToString());
                    personal.Series[0].Points.AddXY(table.Rows[i].ItemArray[0].ToString(), (int)percentage);
                }
            }
           
            // Set the chart title
            this.personal.Titles.Add("Self Management");
            // Set chart type like Bar chart, Pie chart 
            personal.Series["Series1"].ChartType = SeriesChartType.Pie;
            // To show chart value           
            personal.Series["Series1"].IsValueShownAsLabel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
       
            thread = new Thread(open_personal_form);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(open_career_form);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(open_other_form);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public void open_personal_form()
        {
            Application.Run(new BackLog("personal"));
        }
        private void open_career_form(object obj)
        {
            Application.Run(new BackLog("career"));
        }
        private void open_other_form(object obj)
        {
            Application.Run(new BackLog("other"));
        }

      
    }
}
