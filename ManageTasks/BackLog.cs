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

namespace ManageTasks
{
    public partial class BackLog : Form
    {
        Thread thread;
        DataTable table;
        string query = string.Empty;
        string type = string.Empty;
        public BackLog(string type)
        {
            InitializeComponent();
            this.type = type;
        }

        private void BackLog_Load(object sender, EventArgs e)
        {

            this.ActiveControl = name;
            if (type.Equals("other")) calender.Visible = true; else calender.Visible = false;
            LoadGridView();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(name.Text))
            {
                name.Focus();
                MessageBox.Show("Insert goal name");
            }

            else if (String.IsNullOrEmpty(description.Text))
            {
                description.Focus();
                MessageBox.Show("Insert goal description");
            }
            else if (String.IsNullOrEmpty(maskedTextBox1.Text))
            {
                maskedTextBox1.Focus();
                MessageBox.Show("Insert goal start date");
            }
            else if (String.IsNullOrEmpty(maskedTextBox2.Text))
            {
                maskedTextBox2.Focus();
                MessageBox.Show("Insert goal end date");
            }

          
            else
            {            
                query = "insert into Task (name,description,startdate,enddate,type) values(N'" + name.Text + "',N'" + description.Text +"',CAST('" + DateTime.Parse(maskedTextBox1.Text).ToString("yyyy/MM/dd") + "' as DATETIME),CAST('" + DateTime.Parse(maskedTextBox2.Text).ToString("yyyy/MM/dd") + "' as DATETIME),'"+type+"')";
                int affectes = DAL.ConnectionEnvironment(query);
                RefreshGridView();
            //    MessageBox.Show(affectes.ToString());
            }
        }

     

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(name.Text))
                {
                    name.Focus();
                    MessageBox.Show("Insert goal name");
                }

                else if (String.IsNullOrEmpty(description.Text))
                {
                    description.Focus();
                    MessageBox.Show("Insert goal description");
                }
                else if (String.IsNullOrEmpty(maskedTextBox1.Text))
                {
                    maskedTextBox1.Focus();
                    MessageBox.Show("Insert goal start date");
                }
                else if (String.IsNullOrEmpty(maskedTextBox2.Text))
                {
                    maskedTextBox2.Focus();
                    MessageBox.Show("Insert goal end date");
                }


                else
                {
                    query = "update Task set name=N'" + name.Text + "',description=N'" + description.Text + "',startdate=CAST('" + DateTime.Parse(maskedTextBox1.Text).ToString("yyyy/MM/dd") + "' AS DATETIME),enddate=CAST('" + DateTime.Parse(maskedTextBox2.Text).ToString("yyyy/MM/dd") + "' AS DATETIME) where Id =" + Int32.Parse(labelID.Text) + "";
                    int affected = DAL.ConnectionEnvironment(query);
                    RefreshGridView();
                    //  MessageBox.Show(affected.ToString());
                }
            }
            catch (Exception e1) { MessageBox.Show("All fields must be filled"); }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(labelID.Text) && !string.IsNullOrEmpty(name.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to delete this goal? ", "Delete Goal", MessageBoxButtons.YesNo);
if(dialogResult == DialogResult.Yes)
{
      query = "delete from Task where Id = " + Int32.Parse(labelID.Text) + "";
                    int affected = DAL.ConnectionEnvironment(query);
                    RefreshGridView();
}
else if (dialogResult == DialogResult.No) { }
                 
                  
                }
            }
            catch (Exception e1) { }
            }

       
     

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
              //  MessageBox.Show(dataGridView1[3, e.RowIndex].Value.ToString());
             //   MessageBox.Show(dataGridView1[0, e.RowIndex].Value.ToString());

                name.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                description.Text = dataGridView1[2, e.RowIndex].Value.ToString();            
                labelID.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                maskedTextBox1.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                maskedTextBox2.Text = dataGridView1[4, e.RowIndex].Value.ToString();
              
            }
            catch (Exception e1) { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (e.ColumnIndex == 5)
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                    e.RowIndex >= 0)
                {
                    if (!string.IsNullOrEmpty(labelID.Text))
                    {
                        RPM rpm = new RPM(labelID.Text);
                        rpm.Show();
                    }
                }
            }
          
        }
        private void RefreshGridView()
        {
            try
            {
                dataGridView1.Columns.RemoveAt(5);
                query = "SELECT t.Id, t.name as [Goal Name], t.description as [Goal Description],t.startdate as [Start Date],t.enddate as [End Date] FROM Task AS t where t.type='" + type + "'";
                dataGridView1.DataSource = DAL.dynamicTConnection(query);
                DataGridViewLinkColumn manage = new DataGridViewLinkColumn();


                manage.Name = "Manage";
                manage.LinkColor = Color.Blue;
                manage.TrackVisitedState = true;
                manage.Text = "Manage";
                manage.UseColumnTextForLinkValue = true;



                dataGridView1.Columns.Add(manage);

                dataGridView1.Columns[5].HeaderText = "";
             
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void LoadGridView()
        {
            try
            {
                query = "SELECT t.Id, t.name as [Goal Name], t.description as [Goal Description],t.startdate as [Start Date],t.enddate as [End Date] FROM Task AS t where t.type='" + type + "'";
                dataGridView1.DataSource = DAL.dynamicTConnection(query);
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[1].Visible = true;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[1].Width = 300;
                dataGridView1.Columns[2].Visible = true;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[2].Width = 650;
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[4].ReadOnly = true;
                dataGridView1.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
                DataGridViewLinkColumn manage = new DataGridViewLinkColumn();
               
              
                manage.Name = "Manage";
                manage.LinkColor = Color.Blue;
                manage.TrackVisitedState = true;
                manage.Text = "Manage";
                manage.UseColumnTextForLinkValue = true;
               

               
                dataGridView1.Columns.Add(manage);
              
                dataGridView1.Columns[5].HeaderText = "";
             
               
             
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
                    
        }

      

       
        private void cleartask_Click(object sender, EventArgs e)
        {
          
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            name.Text = string.Empty;
            description.Text = string.Empty;
          
        }

        private void name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(name.Text))
                {
                    description.Focus();
                } else name.Focus();
            }
        }

        private void description_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(description.Text))
                {
                    maskedTextBox1.Focus();
                }else description.Focus();
            }
        }

      

       

      
        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (maskedTextBox1.MaskCompleted)
                {
                    maskedTextBox2.Focus();
                }
                else
                {
                    maskedTextBox1.Clear();
                    maskedTextBox1.Focus();
                }
            }
        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar == (char)Keys.Enter)
            {
                if (!maskedTextBox2.MaskCompleted)
                {
                     maskedTextBox2.Clear();
                    maskedTextBox2.Focus();
                }
              
            
        }
        }

        private void homepage_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(open_home_form);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }


        public void open_home_form()
        {
            Application.Run(new HomePage());
        }

        private void calender_Click(object sender, EventArgs e)
        {
            Calender calender = new Calender();
            calender.Show();
        }

      
    }
}
