using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageTasks
{
    
    public partial class Calender : Form
    {
        string query = string.Empty;
        DataTable table;
        public Calender()
        {
            
            InitializeComponent();
        }

        private void Calender_Load(object sender, EventArgs e)
        {
            this.ActiveControl = calendertask;
            query = "select Id, task as [Task],location as [Location],date as[Date],time as [Time] from Calender";
            table = new DataTable();
            table = DAL.dynamicTConnection(query);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 450;
            dataGridView1.Columns[2].Width = 300;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[3].DefaultCellStyle.Format = "ddd/MMM/yyyy";
           

        }

        private void calenderpush_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(calendertask.Text)) calendertask.Focus();
                else if (!maskedTextBoxDate.MaskCompleted) maskedTextBoxDate.Focus();
                else if (!maskedTextBoxTime.MaskCompleted) maskedTextBoxTime.Focus();
                else if (string.IsNullOrEmpty(calenderwhere.Text)) calenderwhere.Focus();
                else
                {
                    query = "insert into Calender values('"+calendertask.Text+"','"+calenderwhere.Text+"',CAST('"+DateTime.Parse(maskedTextBoxDate.Text).ToString("yyyy/MM/dd")+"' as DATETIME),CAST('"+DateTime.Parse(maskedTextBoxTime.Text).ToString("hh:mm")+"'as DATETIME))";
                    int affected = DAL.ConnectionEnvironment(query);
                    RefreshGridView();
                  //  MessageBox.Show(affected.ToString());
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void calenederchange_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(calendertask.Text)) calendertask.Focus();
                else if (!maskedTextBoxDate.MaskCompleted) maskedTextBoxDate.Focus();
                else if (!maskedTextBoxTime.MaskCompleted) maskedTextBoxTime.Focus();
                else if (string.IsNullOrEmpty(calenderwhere.Text)) calenderwhere.Focus();
                else
                {
                    query = "update Calender set task='"+calendertask.Text+"',date=CAST('"+DateTime.Parse(maskedTextBoxDate.Text).ToString("yyyy/MM/dd")+"' as DATETIME), time=CAST('"+DateTime.Parse(maskedTextBoxTime.Text).ToString("hh:mm")+"' as DATETIME),location='"+calenderwhere.Text+"' where Id="+Int32.Parse(labelID.Text)+"";
                    int affected = DAL.ConnectionEnvironment(query);
                    RefreshGridView();
                    //MessageBox.Show(affected.ToString());
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void calendercleaer_Click(object sender, EventArgs e)
        {
            calenderwhere.Clear();
            calendertask.Clear();
            maskedTextBoxTime.Clear();
            maskedTextBoxDate.Clear();
            calendertask.Focus();
        }

        private void calendertrash_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(labelID.Text) && !string.IsNullOrEmpty(calendertask.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to delete this Task? ", "Delete Task", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    query = "delete from Calender where Id = " + Int32.Parse(labelID.Text) + "";
                    int affected = DAL.ConnectionEnvironment(query);
                    RefreshGridView();
                }
                else if (dialogResult == DialogResult.No) { }
            }
        }

        private void today_Click(object sender, EventArgs e)
        {
            query = "select Id, task as [Task],location as [Location],date as[Date],time as [Time] from Calender where date = CAST(GETDATE() AS DATE)";
            FilterGridView(query);
        }

        

private void RefreshGridView()
{
    query = "select Id, task as [Task],location as [Location],date as[Date],time as [Time] from Calender";
    table = new DataTable();
    table = DAL.dynamicTConnection(query);
    dataGridView1.DataSource = table;
}
private void FilterGridView(string command)
{
    table = new DataTable();
    table = DAL.dynamicTConnection(command);
    dataGridView1.DataSource = table;
}
        
       private void week_Click(object sender, EventArgs e)
        {
            DateTime[] date = weekFromDateTime();
            query = "select Id, task as [Task],location as [Location],date as[Date],time as [Time] from Calender where date between CAST('"+date[0].ToString("yyyy/MM/dd")+"' as DATE) and CAST('"+date[1].ToString("yyyy/MM/dd")+"' as DATE) ";
            FilterGridView(query); 
       }

        private void month_Click(object sender, EventArgs e)
        {
            query = "select Id, task as [Task],location as [Location],date as[Date],time as [Time] from Calender WHERE MONTH(date) = MONTH(getdate()) AND YEAR(date) = YEAR(getdate())";
            FilterGridView(query); 
        }

        private void year_Click(object sender, EventArgs e)
        {
            query = "select Id, task as [Task],location as [Location],date as[Date],time as [Time]  from Calender WHERE  YEAR(date) = YEAR(getdate())";
            FilterGridView(query); 
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                labelID.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                calendertask.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                maskedTextBoxDate.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                maskedTextBoxTime.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                calenderwhere.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            }
            catch (Exception e1) { }
        }

        private void calendertask_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (string.IsNullOrEmpty(calendertask.Text)) calendertask.Focus();
                else maskedTextBoxDate.Focus();
                
            }
        }

        private void maskedTextBoxDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                if (maskedTextBoxDate.MaskCompleted) maskedTextBoxTime.Focus();
                else { maskedTextBoxDate.Clear(); maskedTextBoxDate.Focus(); }
            
            }
            }

        private void maskedTextBoxTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (maskedTextBoxTime.MaskCompleted) calenderwhere.Focus();
                else
                {
                    maskedTextBoxTime.Clear();
                    maskedTextBoxTime.Focus();
                }
            }
        }

        private void maskedTextBoxsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
               
                if (maskedTextBoxsearch.MaskCompleted)
                {
                    query = "select Id, task as [Task],location as [Location],date as[Date],time as [Time] from Calender where date=CAST('" + DateTime.Parse(maskedTextBoxsearch.Text).ToString("yyyy/MM/dd") + "' as DATETIME)";
                    FilterGridView(query);
                }
            }
        }

        private DateTime[] weekFromDateTime()
        {
            string day_of_week = System.DateTime.Now.DayOfWeek.ToString();
            DateTime start_date;
            DateTime end_date;
            
            switch (day_of_week)
            {
                case "Friday": start_date = System.DateTime.Now.AddDays(-4);
                    end_date = System.DateTime.Now.AddDays(+2);
                    break;
                case "Saturday": start_date = System.DateTime.Now.AddDays(-5);

                    end_date = System.DateTime.Now.AddDays(+1);
                   break;
                case "Sunday": start_date = System.DateTime.Now.AddDays(-6);
                   end_date = System.DateTime.Now.AddDays(0); 
                    break;
                case "Monday": start_date = System.DateTime.Now.AddDays(0);
                    end_date = System.DateTime.Now.AddDays(+6);
                    break;
                case "Tuesday": start_date = System.DateTime.Now.AddDays(-1);
                    end_date = System.DateTime.Now.AddDays(+5);
                    break;
                case "Wednesday": start_date = System.DateTime.Now.AddDays(-2);
                    end_date = System.DateTime.Now.AddDays(+4);
                    break;
                case "Thursday": start_date = System.DateTime.Now.AddDays(-3);
                    end_date = System.DateTime.Now.AddDays(+3);
                    break;
                default: start_date = System.DateTime.Now.AddYears(10); 
                      end_date = System.DateTime.Now.AddYears(10);
                    break;
            }
            DateTime[] range_date = { start_date,end_date};
           
            return range_date;

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
              //  MessageBox.Show(DateTime.Parse(dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString()).ToShortDateString());
              //  MessageBox.Show(System.DateTime.Now.ToShortDateString());
                if  (dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString().Equals(System.DateTime.Now))
                    dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.LightGreen;
                else if (dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString().Equals(System.DateTime.Now.AddDays(1)))
                    dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Blue;
                else if (dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString().Equals(System.DateTime.Now.AddDays(-1)))
                    dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;
            }
        }

        

      
    }
}
