namespace ManageTasks
{
    partial class RPM
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textoutcome = new System.Windows.Forms.TextBox();
            this.textmap = new System.Windows.Forms.TextBox();
            this.textpurpose = new System.Windows.Forms.TextBox();
            this.pushoutcome = new System.Windows.Forms.Button();
            this.pushpurpose = new System.Windows.Forms.Button();
            this.pushmap = new System.Windows.Forms.Button();
            this.dataGridViewOutcome = new System.Windows.Forms.DataGridView();
            this.dataGridViewPurpose = new System.Windows.Forms.DataGridView();
            this.dataGridViewMap = new System.Windows.Forms.DataGridView();
            this.changemap = new System.Windows.Forms.Button();
            this.changepurpose = new System.Windows.Forms.Button();
            this.changeoutcome = new System.Windows.Forms.Button();
            this.pullmap = new System.Windows.Forms.Button();
            this.pullpurpose = new System.Windows.Forms.Button();
            this.pulloutcome = new System.Windows.Forms.Button();
            this.taskdescription = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.enddate = new System.Windows.Forms.Label();
            this.startdate = new System.Windows.Forms.Label();
            this.taskname = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelRPM = new System.Windows.Forms.Label();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.priorityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ManageTasks.DataSet1();
            this.taskTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priorityTableAdapter = new ManageTasks.DataSet1TableAdapters.PriorityTableAdapter();
            this.task_TypeTableAdapter = new ManageTasks.DataSet1TableAdapters.Task_TypeTableAdapter();
            this.label20 = new System.Windows.Forms.Label();
            this.clearmap = new System.Windows.Forms.Button();
            this.clearoutcome = new System.Windows.Forms.Button();
            this.clearpurpose = new System.Windows.Forms.Button();
            this.combotype_id = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutcome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurpose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "What?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(22, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "How?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(22, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Why?";
            // 
            // textoutcome
            // 
            this.textoutcome.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoutcome.Location = new System.Drawing.Point(105, 41);
            this.textoutcome.Name = "textoutcome";
            this.textoutcome.Size = new System.Drawing.Size(871, 25);
            this.textoutcome.TabIndex = 3;
            // 
            // textmap
            // 
            this.textmap.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textmap.Location = new System.Drawing.Point(105, 357);
            this.textmap.Name = "textmap";
            this.textmap.Size = new System.Drawing.Size(871, 25);
            this.textmap.TabIndex = 4;
            this.textmap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textmap_KeyDown);
            // 
            // textpurpose
            // 
            this.textpurpose.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpurpose.Location = new System.Drawing.Point(105, 197);
            this.textpurpose.Name = "textpurpose";
            this.textpurpose.Size = new System.Drawing.Size(871, 25);
            this.textpurpose.TabIndex = 5;
            // 
            // pushoutcome
            // 
            this.pushoutcome.BackColor = System.Drawing.Color.Azure;
            this.pushoutcome.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pushoutcome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pushoutcome.Location = new System.Drawing.Point(1035, 69);
            this.pushoutcome.Name = "pushoutcome";
            this.pushoutcome.Size = new System.Drawing.Size(102, 55);
            this.pushoutcome.TabIndex = 6;
            this.pushoutcome.Text = "Push";
            this.pushoutcome.UseVisualStyleBackColor = false;
            this.pushoutcome.Click += new System.EventHandler(this.pushoutcome_Click);
            // 
            // pushpurpose
            // 
            this.pushpurpose.BackColor = System.Drawing.Color.Azure;
            this.pushpurpose.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pushpurpose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pushpurpose.Location = new System.Drawing.Point(1035, 226);
            this.pushpurpose.Name = "pushpurpose";
            this.pushpurpose.Size = new System.Drawing.Size(102, 54);
            this.pushpurpose.TabIndex = 7;
            this.pushpurpose.Text = "Push";
            this.pushpurpose.UseVisualStyleBackColor = false;
            this.pushpurpose.Click += new System.EventHandler(this.pushpurpose_Click);
            // 
            // pushmap
            // 
            this.pushmap.BackColor = System.Drawing.Color.Azure;
            this.pushmap.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pushmap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pushmap.Location = new System.Drawing.Point(1038, 500);
            this.pushmap.Name = "pushmap";
            this.pushmap.Size = new System.Drawing.Size(102, 59);
            this.pushmap.TabIndex = 8;
            this.pushmap.Text = "Push";
            this.pushmap.UseVisualStyleBackColor = false;
            this.pushmap.Click += new System.EventHandler(this.pushmap_Click);
            // 
            // dataGridViewOutcome
            // 
            this.dataGridViewOutcome.AllowUserToAddRows = false;
            this.dataGridViewOutcome.AllowUserToDeleteRows = false;
            this.dataGridViewOutcome.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOutcome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewOutcome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOutcome.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewOutcome.EnableHeadersVisualStyles = false;
            this.dataGridViewOutcome.Location = new System.Drawing.Point(105, 69);
            this.dataGridViewOutcome.Name = "dataGridViewOutcome";
            this.dataGridViewOutcome.ReadOnly = true;
            this.dataGridViewOutcome.Size = new System.Drawing.Size(873, 122);
            this.dataGridViewOutcome.TabIndex = 9;
            this.dataGridViewOutcome.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOutcome_RowEnter);
            // 
            // dataGridViewPurpose
            // 
            this.dataGridViewPurpose.AllowUserToAddRows = false;
            this.dataGridViewPurpose.AllowUserToDeleteRows = false;
            this.dataGridViewPurpose.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPurpose.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewPurpose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPurpose.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewPurpose.EnableHeadersVisualStyles = false;
            this.dataGridViewPurpose.Location = new System.Drawing.Point(105, 229);
            this.dataGridViewPurpose.Name = "dataGridViewPurpose";
            this.dataGridViewPurpose.ReadOnly = true;
            this.dataGridViewPurpose.Size = new System.Drawing.Size(873, 121);
            this.dataGridViewPurpose.TabIndex = 10;
            this.dataGridViewPurpose.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPurpose_RowEnter);
            // 
            // dataGridViewMap
            // 
            this.dataGridViewMap.AllowUserToAddRows = false;
            this.dataGridViewMap.AllowUserToDeleteRows = false;
            this.dataGridViewMap.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMap.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewMap.EnableHeadersVisualStyles = false;
            this.dataGridViewMap.Location = new System.Drawing.Point(105, 389);
            this.dataGridViewMap.Name = "dataGridViewMap";
            this.dataGridViewMap.ReadOnly = true;
            this.dataGridViewMap.Size = new System.Drawing.Size(871, 309);
            this.dataGridViewMap.TabIndex = 11;
            this.dataGridViewMap.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewMap_CellFormatting);
            this.dataGridViewMap.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMap_RowEnter);
            // 
            // changemap
            // 
            this.changemap.BackColor = System.Drawing.Color.Azure;
            this.changemap.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changemap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.changemap.Location = new System.Drawing.Point(1206, 500);
            this.changemap.Name = "changemap";
            this.changemap.Size = new System.Drawing.Size(102, 59);
            this.changemap.TabIndex = 17;
            this.changemap.Text = "Change";
            this.changemap.UseVisualStyleBackColor = false;
            this.changemap.Click += new System.EventHandler(this.changemap_Click);
            // 
            // changepurpose
            // 
            this.changepurpose.BackColor = System.Drawing.Color.Azure;
            this.changepurpose.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changepurpose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.changepurpose.Location = new System.Drawing.Point(1206, 225);
            this.changepurpose.Name = "changepurpose";
            this.changepurpose.Size = new System.Drawing.Size(100, 57);
            this.changepurpose.TabIndex = 16;
            this.changepurpose.Text = "Change";
            this.changepurpose.UseVisualStyleBackColor = false;
            this.changepurpose.Click += new System.EventHandler(this.changepurpose_Click);
            // 
            // changeoutcome
            // 
            this.changeoutcome.BackColor = System.Drawing.Color.Azure;
            this.changeoutcome.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeoutcome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.changeoutcome.Location = new System.Drawing.Point(1204, 66);
            this.changeoutcome.Name = "changeoutcome";
            this.changeoutcome.Size = new System.Drawing.Size(102, 55);
            this.changeoutcome.TabIndex = 15;
            this.changeoutcome.Text = "Change";
            this.changeoutcome.UseVisualStyleBackColor = false;
            this.changeoutcome.Click += new System.EventHandler(this.changeoutcome_Click);
            // 
            // pullmap
            // 
            this.pullmap.BackColor = System.Drawing.Color.Azure;
            this.pullmap.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pullmap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pullmap.Location = new System.Drawing.Point(1208, 595);
            this.pullmap.Name = "pullmap";
            this.pullmap.Size = new System.Drawing.Size(102, 59);
            this.pullmap.TabIndex = 20;
            this.pullmap.Text = "Trash";
            this.pullmap.UseVisualStyleBackColor = false;
            this.pullmap.Click += new System.EventHandler(this.pullmap_Click);
            // 
            // pullpurpose
            // 
            this.pullpurpose.BackColor = System.Drawing.Color.Azure;
            this.pullpurpose.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pullpurpose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pullpurpose.Location = new System.Drawing.Point(1208, 285);
            this.pullpurpose.Name = "pullpurpose";
            this.pullpurpose.Size = new System.Drawing.Size(100, 59);
            this.pullpurpose.TabIndex = 19;
            this.pullpurpose.Text = "Trash";
            this.pullpurpose.UseVisualStyleBackColor = false;
            this.pullpurpose.Click += new System.EventHandler(this.pullpurpose_Click);
            // 
            // pulloutcome
            // 
            this.pulloutcome.BackColor = System.Drawing.Color.Azure;
            this.pulloutcome.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulloutcome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pulloutcome.Location = new System.Drawing.Point(1206, 131);
            this.pulloutcome.Name = "pulloutcome";
            this.pulloutcome.Size = new System.Drawing.Size(102, 55);
            this.pulloutcome.TabIndex = 18;
            this.pulloutcome.Text = "Trash";
            this.pulloutcome.UseVisualStyleBackColor = false;
            this.pulloutcome.Click += new System.EventHandler(this.pulloutcome_Click);
            // 
            // taskdescription
            // 
            this.taskdescription.AutoSize = true;
            this.taskdescription.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskdescription.Location = new System.Drawing.Point(501, 3);
            this.taskdescription.Name = "taskdescription";
            this.taskdescription.Size = new System.Drawing.Size(0, 24);
            this.taskdescription.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1032, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 24);
            this.label11.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1032, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 24);
            this.label12.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1178, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 24);
            this.label13.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1046, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 24);
            this.label14.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(1119, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 24);
            this.label15.TabIndex = 29;
            this.label15.Text = "Finish Date:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(894, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 24);
            this.label16.TabIndex = 30;
            this.label16.Text = "Start Date:";
            // 
            // enddate
            // 
            this.enddate.AutoSize = true;
            this.enddate.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enddate.Location = new System.Drawing.Point(1246, 3);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(0, 24);
            this.enddate.TabIndex = 31;
            // 
            // startdate
            // 
            this.startdate.AutoSize = true;
            this.startdate.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdate.Location = new System.Drawing.Point(998, 2);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(0, 24);
            this.startdate.TabIndex = 34;
            // 
            // taskname
            // 
            this.taskname.AutoSize = true;
            this.taskname.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskname.Location = new System.Drawing.Point(146, 2);
            this.taskname.Name = "taskname";
            this.taskname.Size = new System.Drawing.Size(0, 24);
            this.taskname.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(325, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 24);
            this.label7.TabIndex = 35;
            this.label7.Text = "Goal Description:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(21, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 24);
            this.label9.TabIndex = 36;
            this.label9.Text = "Goal Name:";
            // 
            // labelRPM
            // 
            this.labelRPM.AutoSize = true;
            this.labelRPM.Location = new System.Drawing.Point(1032, 67);
            this.labelRPM.Name = "labelRPM";
            this.labelRPM.Size = new System.Drawing.Size(0, 13);
            this.labelRPM.TabIndex = 37;
            this.labelRPM.Visible = false;
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPriority.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPriority.DataSource = this.priorityBindingSource;
            this.comboBoxPriority.DisplayMember = "description";
            this.comboBoxPriority.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(1165, 389);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(193, 26);
            this.comboBoxPriority.TabIndex = 38;
            this.comboBoxPriority.ValueMember = "Id";
            this.comboBoxPriority.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxPriority_KeyDown);
            // 
            // priorityBindingSource
            // 
            this.priorityBindingSource.DataMember = "Priority";
            this.priorityBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taskTypeBindingSource
            // 
            this.taskTypeBindingSource.DataMember = "Task_Type";
            this.taskTypeBindingSource.DataSource = this.dataSet1;
            // 
            // priorityTableAdapter
            // 
            this.priorityTableAdapter.ClearBeforeFill = true;
            // 
            // task_TypeTableAdapter
            // 
            this.task_TypeTableAdapter.ClearBeforeFill = true;
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Location = new System.Drawing.Point(12, 35);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(1341, 2);
            this.label20.TabIndex = 44;
            // 
            // clearmap
            // 
            this.clearmap.BackColor = System.Drawing.Color.Azure;
            this.clearmap.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearmap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clearmap.Location = new System.Drawing.Point(1038, 595);
            this.clearmap.Name = "clearmap";
            this.clearmap.Size = new System.Drawing.Size(102, 59);
            this.clearmap.TabIndex = 50;
            this.clearmap.Text = "Clear";
            this.clearmap.UseVisualStyleBackColor = false;
            this.clearmap.Click += new System.EventHandler(this.clearmap_Click);
            // 
            // clearoutcome
            // 
            this.clearoutcome.BackColor = System.Drawing.Color.Azure;
            this.clearoutcome.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearoutcome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clearoutcome.Location = new System.Drawing.Point(1038, 131);
            this.clearoutcome.Name = "clearoutcome";
            this.clearoutcome.Size = new System.Drawing.Size(102, 55);
            this.clearoutcome.TabIndex = 51;
            this.clearoutcome.Text = "Clear";
            this.clearoutcome.UseVisualStyleBackColor = false;
            this.clearoutcome.Click += new System.EventHandler(this.clearoutcome_Click);
            // 
            // clearpurpose
            // 
            this.clearpurpose.BackColor = System.Drawing.Color.Azure;
            this.clearpurpose.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearpurpose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clearpurpose.Location = new System.Drawing.Point(1035, 285);
            this.clearpurpose.Name = "clearpurpose";
            this.clearpurpose.Size = new System.Drawing.Size(100, 54);
            this.clearpurpose.TabIndex = 52;
            this.clearpurpose.Text = "Clear";
            this.clearpurpose.UseVisualStyleBackColor = false;
            this.clearpurpose.Click += new System.EventHandler(this.clearpurpose_Click);
            // 
            // combotype_id
            // 
            this.combotype_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combotype_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combotype_id.DataSource = this.taskTypeBindingSource;
            this.combotype_id.DisplayMember = "description";
            this.combotype_id.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combotype_id.FormattingEnabled = true;
            this.combotype_id.Location = new System.Drawing.Point(1165, 421);
            this.combotype_id.Name = "combotype_id";
            this.combotype_id.Size = new System.Drawing.Size(193, 26);
            this.combotype_id.TabIndex = 53;
            this.combotype_id.ValueMember = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(1047, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 54;
            this.label4.Text = "Task Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1047, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 55;
            this.label5.Text = "Task Priority:";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(12, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1356, 3);
            this.label6.TabIndex = 56;
            this.label6.Text = "label6";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(12, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1356, 3);
            this.label8.TabIndex = 57;
            this.label8.Text = "label8";
            // 
            // RPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combotype_id);
            this.Controls.Add(this.clearpurpose);
            this.Controls.Add(this.clearoutcome);
            this.Controls.Add(this.clearmap);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.labelRPM);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.startdate);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.taskname);
            this.Controls.Add(this.taskdescription);
            this.Controls.Add(this.pullmap);
            this.Controls.Add(this.pullpurpose);
            this.Controls.Add(this.pulloutcome);
            this.Controls.Add(this.changemap);
            this.Controls.Add(this.changepurpose);
            this.Controls.Add(this.changeoutcome);
            this.Controls.Add(this.dataGridViewMap);
            this.Controls.Add(this.dataGridViewPurpose);
            this.Controls.Add(this.dataGridViewOutcome);
            this.Controls.Add(this.pushmap);
            this.Controls.Add(this.pushpurpose);
            this.Controls.Add(this.pushoutcome);
            this.Controls.Add(this.textpurpose);
            this.Controls.Add(this.textmap);
            this.Controls.Add(this.textoutcome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "RPM";
            this.Text = "RPM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RPM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutcome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurpose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textoutcome;
        private System.Windows.Forms.TextBox textmap;
        private System.Windows.Forms.TextBox textpurpose;
        private System.Windows.Forms.Button pushoutcome;
        private System.Windows.Forms.Button pushpurpose;
        private System.Windows.Forms.Button pushmap;
        private System.Windows.Forms.DataGridView dataGridViewOutcome;
        private System.Windows.Forms.DataGridView dataGridViewPurpose;
        private System.Windows.Forms.DataGridView dataGridViewMap;
        private System.Windows.Forms.Button changemap;
        private System.Windows.Forms.Button changepurpose;
        private System.Windows.Forms.Button changeoutcome;
        private System.Windows.Forms.Button pullmap;
        private System.Windows.Forms.Button pullpurpose;
        private System.Windows.Forms.Button pulloutcome;
        private System.Windows.Forms.Label taskdescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label enddate;
        private System.Windows.Forms.Label startdate;
        private System.Windows.Forms.Label taskname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelRPM;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource priorityBindingSource;
        private DataSet1TableAdapters.PriorityTableAdapter priorityTableAdapter;
        private System.Windows.Forms.BindingSource taskTypeBindingSource;
        private DataSet1TableAdapters.Task_TypeTableAdapter task_TypeTableAdapter;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button clearmap;
        private System.Windows.Forms.Button clearoutcome;
        private System.Windows.Forms.Button clearpurpose;
        private System.Windows.Forms.ComboBox combotype_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}