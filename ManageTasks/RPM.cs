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
    public partial class RPM : Form
    {
        string Id;
        string query= string.Empty;
        DataTable table;
        public RPM(string Id)
        {
            InitializeComponent();
            this.Id = Id;
        }

        private void RPM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Task_Type' table. You can move, or remove it, as needed.
            this.task_TypeTableAdapter.Fill(this.dataSet1.Task_Type);
            // TODO: This line of code loads data into the 'dataSet1.Priority' table. You can move, or remove it, as needed.
            this.priorityTableAdapter.Fill(this.dataSet1.Priority);
            query = "SELECT   t.name , t.description,t.startdate,t.enddate FROM Task AS t where t.Id="+Int32.Parse(Id)+"";
            table = new DataTable();
            table = DAL.dynamicTConnection(query);
            if (table.Rows.Count > 0)
            {
                taskname.Text = table.Rows[0].ItemArray[0].ToString();
                taskdescription.Text = table.Rows[0].ItemArray[1].ToString();         
                startdate.Text =DateTime.Parse(table.Rows[0].ItemArray[2].ToString()).ToShortDateString();
                enddate.Text =DateTime.Parse(table.Rows[0].ItemArray[3].ToString()).ToShortDateString();
            }
            LoadGridViews();
        }

        private void LoadGridViews()
        {
            query = "select Id, description as [OUTCOME] from Outcome_What where task_id ="+Id+"";
            table = new DataTable();
            table = DAL.dynamicTConnection(query);
            dataGridViewOutcome.DataSource = table;
            dataGridViewOutcome.Columns[0].Visible = false;
            dataGridViewOutcome.Columns[1].Width = 815;

            query = "select Id, description as [PURPOSE] from Purpose_Why where task_id =" + Id + "";
            table = new DataTable();
            table = DAL.dynamicTConnection(query);
            dataGridViewPurpose.DataSource = table;
            dataGridViewPurpose.Columns[0].Visible = false;
            dataGridViewPurpose.Columns[1].Width = 815;

            query = "select m.Id,m.priority_id,m.type_id, m.description as [MAP],p.description as [Task Priority], t.description as [Status] from MAP_How m inner join Priority p on m.priority_id=p.Id inner join Task_Type t on t.Id=m.type_id where m.task_id =" + Id + "";
            table = new DataTable();
            table = DAL.dynamicTConnection(query);
            dataGridViewMap.DataSource = DAL.table;
            dataGridViewMap.Columns[0].Visible = false;
            dataGridViewMap.Columns[1].Visible = false;
            dataGridViewMap.Columns[2].Visible = false;
            dataGridViewMap.Columns[3].Width = 540;
            dataGridViewMap.Columns[4].Width = 195;
            dataGridViewMap.Columns[5].Width = 90;

        }

        private void RefreshGridViews(string who)
        {
            if(who.Equals("What"))
            {
                query = "select Id, description as [OUTCOME] from Outcome_What where task_id =" + Id + "";
            table = new DataTable();
            table = DAL.dynamicTConnection(query);
            dataGridViewOutcome.DataSource = table;
            }
            else if (who.Equals("Why"))
            {
                query = "select Id, description as [PURPOSE] from Purpose_Why where task_id =" + Id + "";
                table = new DataTable();
                table = DAL.dynamicTConnection(query);
                dataGridViewPurpose.DataSource = table;
            }
            else if (who.Equals("How"))
            {
                query = "select m.Id,m.priority_id,m.type_id, m.description as [MAP],p.description as [Task Priority], t.description as [Status] from MAP_How m inner join Priority p on m.priority_id=p.Id inner join Task_Type t on t.Id=m.type_id where m.task_id =" + Id + "";
                table = new DataTable();
                table = DAL.dynamicTConnection(query);
                dataGridViewMap.DataSource = DAL.table;
            }

        }

        private void pushoutcome_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textoutcome.Text))
            {
                query = "Insert into Outcome_What values(" + Int32.Parse(Id) + ",N'" + textoutcome.Text + "')";
                int affected = DAL.ConnectionEnvironment(query);
                RefreshGridViews("What");
            }
            else textoutcome.Focus();
        }

        private void pushpurpose_Click(object sender, EventArgs e)
        {
             if (!string.IsNullOrEmpty(textpurpose.Text))
            {
            query = "Insert into Purpose_Why values(" + Int32.Parse(Id) + ",N'" + textpurpose.Text + "')";
            int affected = DAL.ConnectionEnvironment(query);
            RefreshGridViews("Why");
            }
             else textpurpose.Focus();
        }

        private void pushmap_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textmap.Text))
                { 
                query = "Insert into MAP_How (task_id,priority_id,type_id,description) values(" + Id + "," + Int32.Parse(comboBoxPriority.SelectedValue.ToString()) + ","+Int32.Parse(combotype_id.SelectedValue.ToString())+",N'" + textmap.Text + "')";
                int affected = DAL.ConnectionEnvironment(query);
                RefreshGridViews("How");
                }
                else textmap.Focus();
            }
            catch (Exception e1) { }
        }

        private void pulloutcome_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(labelRPM.Text))
            {
                query = "delete Outcome_What where Id = " + Int32.Parse(labelRPM.Text) + "";
                int affected = DAL.ConnectionEnvironment(query);
                RefreshGridViews("What");
            }
        }

        private void pullpurpose_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(labelRPM.Text))
            {
                query = "delete Purpose_Why where Id = " + Int32.Parse(labelRPM.Text) + "";
                int affected = DAL.ConnectionEnvironment(query);
                RefreshGridViews("Why");
            }
        }

        private void pullmap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(labelRPM.Text))
            {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete this task?", "Delete Task", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                query = "delete MAP_How where Id = " + Int32.Parse(labelRPM.Text) + "";
                int affected = DAL.ConnectionEnvironment(query);
                RefreshGridViews("How");
            }
            else if (dialogResult == DialogResult.No) { }
          
               
            }
        }

        private void changeoutcome_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(labelRPM.Text) && !string.IsNullOrEmpty(textoutcome.Text))
                {
                    query = "update Outcome_What set description = N'" + textoutcome.Text + "' where Id =" + Int32.Parse(labelRPM.Text) + "";
                    int affected = DAL.ConnectionEnvironment(query);
                    RefreshGridViews("What");
                }
            }
            catch (Exception e1) { MessageBox.Show("All Map fields must be filled"); }
        }

        private void changepurpose_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(labelRPM.Text) && !string.IsNullOrEmpty(textpurpose.Text))
            {
                query = "update Purpose_Why set description = N'" + textpurpose.Text + "' where Id =" + Int32.Parse(labelRPM.Text) + "";
                int affected = DAL.ConnectionEnvironment(query);
                RefreshGridViews("Why");
            }
        }

        private void changemap_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(textmap.Text) && !string.IsNullOrEmpty(labelRPM.Text))
                {
                    query = "update MAP_How set priority_id=" + Int32.Parse(comboBoxPriority.SelectedValue.ToString()) + ",type_id=" + Int32.Parse(combotype_id.SelectedValue.ToString()) + " ,description = N'" + textmap.Text + "' where Id =" + Int32.Parse(labelRPM.Text) + "";
                    int affected = DAL.ConnectionEnvironment(query);
                    //  MessageBox.Show("Affected");
                    RefreshGridViews("How");
                }
                else textmap.Focus();
            }
            catch (Exception e1) { MessageBox.Show("All Map fields must be filled"); }

        }
        private void dataGridViewOutcome_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textoutcome.Text = dataGridViewOutcome[1, e.RowIndex].Value.ToString();
                labelRPM.Text = dataGridViewOutcome[0, e.RowIndex].Value.ToString();
            }
            catch (Exception e1) { }
        }

        private void dataGridViewPurpose_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textpurpose.Text = dataGridViewPurpose[1, e.RowIndex].Value.ToString();
                labelRPM.Text = dataGridViewPurpose[0, e.RowIndex].Value.ToString();
            }
            catch (Exception e1) { }
        }

        private void dataGridViewMap_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                labelRPM.Text = dataGridViewMap[0, e.RowIndex].Value.ToString();
                query = "select priority_id,type_id, description from MAP_How where Id =" + labelRPM.Text + "";
                table = new DataTable();
                table = DAL.dynamicTConnection(query);
                if (table.Rows.Count > 0)
                {

                    comboBoxPriority.SelectedIndex = Int32.Parse(table.Rows[0].ItemArray[0].ToString()) - 1;
                    combotype_id.SelectedIndex = Int32.Parse(table.Rows[0].ItemArray[1].ToString()) - 1; 
                    textmap.Text = table.Rows[0].ItemArray[2].ToString();
                  
                   
                }
            }
            catch (Exception e1) { MessageBox.Show(e1.ToString()); }
        }

        private void dataGridViewMap_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
               

                if (e.ColumnIndex == 5)
                {
                    if (dataGridViewMap[e.ColumnIndex, e.RowIndex].Value.ToString().Trim().Equals("Actionable"))
                    {
                        dataGridViewMap[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.LightGreen;
                    }
                    if (dataGridViewMap[e.ColumnIndex, e.RowIndex].Value.ToString().Trim().Equals("Next"))
                    {
                        dataGridViewMap[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Orange;
                    }
                    if (dataGridViewMap[e.ColumnIndex, e.RowIndex].Value.ToString().Trim().Equals("Waiting"))
                    {
                        dataGridViewMap[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Yellow;
                    }
                    if (dataGridViewMap[e.ColumnIndex, e.RowIndex].Value.ToString().Trim().Equals("Done"))
                    {
                        dataGridViewMap[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Turquoise;
                    }
                }
                if (e.ColumnIndex == 4)
                {
                    if (dataGridViewMap[e.ColumnIndex, e.RowIndex].Value.ToString().Trim().Equals("Important"))
                    {
                        dataGridViewMap[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Silver;
                    }
                    if (dataGridViewMap[e.ColumnIndex, e.RowIndex].Value.ToString().Trim().Equals("Important and Urgent"))
                    {
                        dataGridViewMap[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Gold;
                    }
                   
                    if (dataGridViewMap[e.ColumnIndex, e.RowIndex].Value.ToString().Trim().Equals("Not Important but Urgent"))
                    {
                        dataGridViewMap[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Wheat;
                    }
                }
            }
            catch (Exception e1) { }
        }

        private void clearmap_Click(object sender, EventArgs e)
        {
          
            textmap.Text = string.Empty;
          
            comboBoxPriority.SelectedIndex = 0;
          
        }

        private void clearoutcome_Click(object sender, EventArgs e)
        {
            textoutcome.Text = string.Empty;
        }

        private void clearpurpose_Click(object sender, EventArgs e)
        {
            textpurpose.Text = string.Empty;
        }

        private void textmap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(textmap.Text))
                {
                    comboBoxPriority.Focus();
                
                }
                else textmap.Focus();
            }
        }

        private void comboBoxPriority_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                combotype_id.Focus();
            }

        }

      

       
        
       

       

      
    }
}
