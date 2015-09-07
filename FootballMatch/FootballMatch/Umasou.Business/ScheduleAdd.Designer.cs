namespace FootballMatch.Umasou.Business
{
    partial class ScheduleAdd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label_seasonNum = new System.Windows.Forms.Label();
            this.label_matchName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button_deleteMultiRows = new System.Windows.Forms.Button();
            this.button_saveSchedule = new System.Windows.Forms.Button();
            this.button_deleteCurrentRow = new System.Windows.Forms.Button();
            this.dateTimePicker_gameDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.turnNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeTeam = new System.Windows.Forms.DataGridViewComboEditBoxColumn();
            this.guestTeam = new System.Windows.Forms.DataGridViewComboEditBoxColumn();
            this.dataGridViewComboEditBoxColumn1 = new System.Windows.Forms.DataGridViewComboEditBoxColumn();
            this.dataGridViewComboEditBoxColumn2 = new System.Windows.Forms.DataGridViewComboEditBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 414);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.linkLabel2);
            this.splitContainer1.Panel2.Controls.Add(this.linkLabel1);
            this.splitContainer1.Panel2.Controls.Add(this.button_deleteMultiRows);
            this.splitContainer1.Panel2.Controls.Add(this.button_saveSchedule);
            this.splitContainer1.Panel2.Controls.Add(this.button_deleteCurrentRow);
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePicker_gameDate);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(546, 414);
            this.splitContainer1.SplitterDistance = 75;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(546, 75);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label_seasonNum);
            this.panel2.Controls.Add(this.label_matchName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(84, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 69);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 14F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(137, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "赛程安排";
            // 
            // label_seasonNum
            // 
            this.label_seasonNum.AutoSize = true;
            this.label_seasonNum.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_seasonNum.ForeColor = System.Drawing.Color.Black;
            this.label_seasonNum.Location = new System.Drawing.Point(56, 5);
            this.label_seasonNum.Name = "label_seasonNum";
            this.label_seasonNum.Size = new System.Drawing.Size(29, 20);
            this.label_seasonNum.TabIndex = 5;
            this.label_seasonNum.Text = "25";
            // 
            // label_matchName
            // 
            this.label_matchName.AutoSize = true;
            this.label_matchName.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_matchName.ForeColor = System.Drawing.Color.Black;
            this.label_matchName.Location = new System.Drawing.Point(124, 6);
            this.label_matchName.Name = "label_matchName";
            this.label_matchName.Size = new System.Drawing.Size(89, 20);
            this.label_matchName.TabIndex = 8;
            this.label_matchName.Text = "中超联赛";
            this.label_matchName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(83, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "季";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(29, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "第";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Fuchsia;
            this.linkLabel2.Location = new System.Drawing.Point(11, 289);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(101, 12);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "查看当前赛季赛程";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.SystemColors.AppWorkspace;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ForeColor = System.Drawing.Color.Red;
            this.linkLabel1.LinkColor = System.Drawing.Color.Fuchsia;
            this.linkLabel1.Location = new System.Drawing.Point(8, 257);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(167, 12);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "excel批量导入到datagridView";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button_deleteMultiRows
            // 
            this.button_deleteMultiRows.Location = new System.Drawing.Point(308, 290);
            this.button_deleteMultiRows.Name = "button_deleteMultiRows";
            this.button_deleteMultiRows.Size = new System.Drawing.Size(75, 30);
            this.button_deleteMultiRows.TabIndex = 2;
            this.button_deleteMultiRows.Text = "删除多行";
            this.button_deleteMultiRows.UseVisualStyleBackColor = true;
            this.button_deleteMultiRows.Click += new System.EventHandler(this.button_deleteMultiRows_Click);
            // 
            // button_saveSchedule
            // 
            this.button_saveSchedule.Location = new System.Drawing.Point(435, 290);
            this.button_saveSchedule.Name = "button_saveSchedule";
            this.button_saveSchedule.Size = new System.Drawing.Size(75, 30);
            this.button_saveSchedule.TabIndex = 2;
            this.button_saveSchedule.Text = "保存赛程";
            this.button_saveSchedule.UseVisualStyleBackColor = true;
            this.button_saveSchedule.Click += new System.EventHandler(this.button_saveSchedule_Click);
            // 
            // button_deleteCurrentRow
            // 
            this.button_deleteCurrentRow.Location = new System.Drawing.Point(186, 290);
            this.button_deleteCurrentRow.Name = "button_deleteCurrentRow";
            this.button_deleteCurrentRow.Size = new System.Drawing.Size(75, 30);
            this.button_deleteCurrentRow.TabIndex = 2;
            this.button_deleteCurrentRow.Text = "删除当前行";
            this.button_deleteCurrentRow.UseVisualStyleBackColor = true;
            this.button_deleteCurrentRow.Click += new System.EventHandler(this.button_deleteCurrentRow_Click);
            // 
            // dateTimePicker_gameDate
            // 
            this.dateTimePicker_gameDate.Location = new System.Drawing.Point(194, 21);
            this.dateTimePicker_gameDate.Name = "dateTimePicker_gameDate";
            this.dateTimePicker_gameDate.Size = new System.Drawing.Size(149, 21);
            this.dateTimePicker_gameDate.TabIndex = 1;
            this.dateTimePicker_gameDate.Visible = false;
            this.dateTimePicker_gameDate.ValueChanged += new System.EventHandler(this.dateTimePicker_gameDate_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.turnNum,
            this.gameDate,
            this.homeTeam,
            this.guestTeam});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(546, 243);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // turnNum
            // 
            this.turnNum.HeaderText = "轮次";
            this.turnNum.Name = "turnNum";
            this.turnNum.Width = 125;
            // 
            // gameDate
            // 
            this.gameDate.HeaderText = "比赛日期";
            this.gameDate.MinimumWidth = 50;
            this.gameDate.Name = "gameDate";
            this.gameDate.Width = 125;
            // 
            // homeTeam
            // 
            this.homeTeam.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.homeTeam.HeaderText = "主队";
            this.homeTeam.Name = "homeTeam";
            this.homeTeam.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.homeTeam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.homeTeam.Width = 125;
            // 
            // guestTeam
            // 
            this.guestTeam.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.guestTeam.HeaderText = "客队";
            this.guestTeam.Name = "guestTeam";
            this.guestTeam.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.guestTeam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.guestTeam.Width = 125;
            // 
            // dataGridViewComboEditBoxColumn1
            // 
            this.dataGridViewComboEditBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboEditBoxColumn1.HeaderText = "主队";
            this.dataGridViewComboEditBoxColumn1.Name = "dataGridViewComboEditBoxColumn1";
            this.dataGridViewComboEditBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboEditBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboEditBoxColumn1.Width = 250;
            // 
            // dataGridViewComboEditBoxColumn2
            // 
            this.dataGridViewComboEditBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboEditBoxColumn2.HeaderText = "客队";
            this.dataGridViewComboEditBoxColumn2.Name = "dataGridViewComboEditBoxColumn2";
            this.dataGridViewComboEditBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboEditBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboEditBoxColumn2.Width = 250;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn1.HeaderText = "主队";
            this.dataGridViewComboBoxColumn1.Items.AddRange(new object[] {
            "重庆力帆",
            "北京国安",
            "浙江绿城",
            "大连实达"});
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn1.Width = 250;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn2.HeaderText = "客队";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn2.Width = 250;
            // 
            // ScheduleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(546, 414);
            this.Controls.Add(this.panel1);
            this.Name = "ScheduleAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScheduleAdd";
            this.Load += new System.EventHandler(this.ScheduleManage_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_seasonNum;
        private System.Windows.Forms.Label label_matchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_gameDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button_saveSchedule;
        private System.Windows.Forms.Button button_deleteCurrentRow;
        private System.Windows.Forms.DataGridViewComboEditBoxColumn dataGridViewComboEditBoxColumn1;
        private System.Windows.Forms.DataGridViewComboEditBoxColumn dataGridViewComboEditBoxColumn2;
        private System.Windows.Forms.Button button_deleteMultiRows;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameDate;
        private System.Windows.Forms.DataGridViewComboEditBoxColumn homeTeam;
        private System.Windows.Forms.DataGridViewComboEditBoxColumn guestTeam;





    }
}