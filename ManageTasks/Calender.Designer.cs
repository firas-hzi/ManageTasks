namespace ManageTasks
{
    partial class Calender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBoxDate = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTime = new System.Windows.Forms.MaskedTextBox();
            this.calenderwhere = new System.Windows.Forms.TextBox();
            this.calendertask = new System.Windows.Forms.TextBox();
            this.today = new System.Windows.Forms.Button();
            this.week = new System.Windows.Forms.Button();
            this.month = new System.Windows.Forms.Button();
            this.year = new System.Windows.Forms.Button();
            this.maskedTextBoxsearch = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.calendercleaer = new System.Windows.Forms.Button();
            this.calendertrash = new System.Windows.Forms.Button();
            this.calenderpush = new System.Windows.Forms.Button();
            this.calenederchange = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(619, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calender";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(88, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 478);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(33, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1246, 2);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(297, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Task";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(768, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(937, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Location";
            // 
            // maskedTextBoxDate
            // 
            this.maskedTextBoxDate.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxDate.Location = new System.Drawing.Point(594, 122);
            this.maskedTextBoxDate.Mask = "00/00/0000";
            this.maskedTextBoxDate.Name = "maskedTextBoxDate";
            this.maskedTextBoxDate.Size = new System.Drawing.Size(153, 25);
            this.maskedTextBoxDate.TabIndex = 7;
            this.maskedTextBoxDate.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxDate_KeyPress);
            // 
            // maskedTextBoxTime
            // 
            this.maskedTextBoxTime.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxTime.Location = new System.Drawing.Point(753, 122);
            this.maskedTextBoxTime.Mask = "90:00";
            this.maskedTextBoxTime.Name = "maskedTextBoxTime";
            this.maskedTextBoxTime.Size = new System.Drawing.Size(86, 25);
            this.maskedTextBoxTime.TabIndex = 8;
            this.maskedTextBoxTime.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxTime_KeyPress);
            // 
            // calenderwhere
            // 
            this.calenderwhere.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calenderwhere.Location = new System.Drawing.Point(845, 122);
            this.calenderwhere.Name = "calenderwhere";
            this.calenderwhere.Size = new System.Drawing.Size(286, 25);
            this.calenderwhere.TabIndex = 9;
            // 
            // calendertask
            // 
            this.calendertask.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendertask.Location = new System.Drawing.Point(88, 122);
            this.calendertask.Name = "calendertask";
            this.calendertask.Size = new System.Drawing.Size(500, 25);
            this.calendertask.TabIndex = 10;
            this.calendertask.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calendertask_KeyDown);
            // 
            // today
            // 
            this.today.BackColor = System.Drawing.Color.Azure;
            this.today.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.today.Location = new System.Drawing.Point(1177, 378);
            this.today.Name = "today";
            this.today.Size = new System.Drawing.Size(133, 56);
            this.today.TabIndex = 12;
            this.today.Text = "Today";
            this.today.UseVisualStyleBackColor = false;
            this.today.Click += new System.EventHandler(this.today_Click);
            // 
            // week
            // 
            this.week.BackColor = System.Drawing.Color.Azure;
            this.week.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.week.Location = new System.Drawing.Point(1177, 450);
            this.week.Name = "week";
            this.week.Size = new System.Drawing.Size(133, 56);
            this.week.TabIndex = 13;
            this.week.Text = "This week";
            this.week.UseVisualStyleBackColor = false;
            this.week.Click += new System.EventHandler(this.week_Click);
            // 
            // month
            // 
            this.month.BackColor = System.Drawing.Color.Azure;
            this.month.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month.Location = new System.Drawing.Point(1177, 525);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(133, 56);
            this.month.TabIndex = 14;
            this.month.Text = "This month";
            this.month.UseVisualStyleBackColor = false;
            this.month.Click += new System.EventHandler(this.month_Click);
            // 
            // year
            // 
            this.year.BackColor = System.Drawing.Color.Azure;
            this.year.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.Location = new System.Drawing.Point(1177, 597);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(133, 56);
            this.year.TabIndex = 16;
            this.year.Text = "This year";
            this.year.UseVisualStyleBackColor = false;
            this.year.Click += new System.EventHandler(this.year_Click);
            // 
            // maskedTextBoxsearch
            // 
            this.maskedTextBoxsearch.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxsearch.Location = new System.Drawing.Point(1160, 122);
            this.maskedTextBoxsearch.Mask = "00/00/0000";
            this.maskedTextBoxsearch.Name = "maskedTextBoxsearch";
            this.maskedTextBoxsearch.Size = new System.Drawing.Size(169, 28);
            this.maskedTextBoxsearch.TabIndex = 17;
            this.maskedTextBoxsearch.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxsearch_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(637, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date";
            // 
            // calendercleaer
            // 
            this.calendercleaer.BackColor = System.Drawing.Color.Azure;
            this.calendercleaer.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendercleaer.Location = new System.Drawing.Point(1182, 251);
            this.calendercleaer.Name = "calendercleaer";
            this.calendercleaer.Size = new System.Drawing.Size(121, 32);
            this.calendercleaer.TabIndex = 18;
            this.calendercleaer.Text = "Clear";
            this.calendercleaer.UseVisualStyleBackColor = false;
            this.calendercleaer.Click += new System.EventHandler(this.calendercleaer_Click);
            // 
            // calendertrash
            // 
            this.calendertrash.BackColor = System.Drawing.Color.Azure;
            this.calendertrash.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendertrash.Location = new System.Drawing.Point(1182, 289);
            this.calendertrash.Name = "calendertrash";
            this.calendertrash.Size = new System.Drawing.Size(121, 32);
            this.calendertrash.TabIndex = 19;
            this.calendertrash.Text = "Trash";
            this.calendertrash.UseVisualStyleBackColor = false;
            this.calendertrash.Click += new System.EventHandler(this.calendertrash_Click);
            // 
            // calenderpush
            // 
            this.calenderpush.BackColor = System.Drawing.Color.Azure;
            this.calenderpush.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calenderpush.Location = new System.Drawing.Point(1182, 175);
            this.calenderpush.Name = "calenderpush";
            this.calenderpush.Size = new System.Drawing.Size(121, 32);
            this.calenderpush.TabIndex = 20;
            this.calenderpush.Text = "Push ";
            this.calenderpush.UseVisualStyleBackColor = false;
            this.calenderpush.Click += new System.EventHandler(this.calenderpush_Click);
            // 
            // calenederchange
            // 
            this.calenederchange.BackColor = System.Drawing.Color.Azure;
            this.calenederchange.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calenederchange.Location = new System.Drawing.Point(1182, 213);
            this.calenederchange.Name = "calenederchange";
            this.calenederchange.Size = new System.Drawing.Size(121, 32);
            this.calenederchange.TabIndex = 21;
            this.calenederchange.Text = "Change";
            this.calenederchange.UseVisualStyleBackColor = false;
            this.calenederchange.Click += new System.EventHandler(this.calenederchange_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(152, 22);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(35, 13);
            this.labelID.TabIndex = 22;
            this.labelID.Text = "label7";
            this.labelID.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(1178, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Search by date";
            // 
            // Calender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.calenederchange);
            this.Controls.Add(this.calenderpush);
            this.Controls.Add(this.calendertrash);
            this.Controls.Add(this.calendercleaer);
            this.Controls.Add(this.maskedTextBoxsearch);
            this.Controls.Add(this.year);
            this.Controls.Add(this.month);
            this.Controls.Add(this.week);
            this.Controls.Add(this.today);
            this.Controls.Add(this.calendertask);
            this.Controls.Add(this.calenderwhere);
            this.Controls.Add(this.maskedTextBoxTime);
            this.Controls.Add(this.maskedTextBoxDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Calender";
            this.Text = "Calender";
            this.Load += new System.EventHandler(this.Calender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTime;
        private System.Windows.Forms.TextBox calenderwhere;
        private System.Windows.Forms.TextBox calendertask;
        private System.Windows.Forms.Button today;
        private System.Windows.Forms.Button week;
        private System.Windows.Forms.Button month;
        private System.Windows.Forms.Button year;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxsearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button calendercleaer;
        private System.Windows.Forms.Button calendertrash;
        private System.Windows.Forms.Button calenderpush;
        private System.Windows.Forms.Button calenederchange;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label7;
    }
}