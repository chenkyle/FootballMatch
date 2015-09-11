namespace FootballMatch.Umasou.Business
{
    partial class playerManage
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox_TeamList = new System.Windows.Forms.ListBox();
            this.dataGridView_playerManage = new System.Windows.Forms.DataGridView();
            this.Player_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerIDnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_playerManage = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel_PlayerExcelImport = new System.Windows.Forms.LinkLabel();
            this.cancel = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.alter = new System.Windows.Forms.Button();
            this.createNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label_teamName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_playerManage)).BeginInit();
            this.groupBox_playerManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox_TeamList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_playerManage);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox_playerManage);
            this.splitContainer1.Size = new System.Drawing.Size(1159, 472);
            this.splitContainer1.SplitterDistance = 216;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBox_TeamList
            // 
            this.listBox_TeamList.BackColor = System.Drawing.Color.White;
            this.listBox_TeamList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_TeamList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox_TeamList.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox_TeamList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox_TeamList.FormattingEnabled = true;
            this.listBox_TeamList.ItemHeight = 35;
            this.listBox_TeamList.Location = new System.Drawing.Point(0, 0);
            this.listBox_TeamList.Name = "listBox_TeamList";
            this.listBox_TeamList.Size = new System.Drawing.Size(216, 472);
            this.listBox_TeamList.Sorted = true;
            this.listBox_TeamList.TabIndex = 0;
            this.listBox_TeamList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_TeamList_DrawItem);
            this.listBox_TeamList.SelectedIndexChanged += new System.EventHandler(this.listBox_TeamList_SelectedIndexChanged);
            // 
            // dataGridView_playerManage
            // 
            this.dataGridView_playerManage.AllowUserToAddRows = false;
            this.dataGridView_playerManage.AllowUserToDeleteRows = false;
            this.dataGridView_playerManage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_playerManage.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_playerManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_playerManage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Player_ID,
            this.player_Name,
            this.player_Number,
            this.player_Position,
            this.player_Team,
            this.playerIDnum});
            this.dataGridView_playerManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_playerManage.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_playerManage.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.dataGridView_playerManage.Name = "dataGridView_playerManage";
            this.dataGridView_playerManage.ReadOnly = true;
            this.dataGridView_playerManage.RowTemplate.Height = 23;
            this.dataGridView_playerManage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_playerManage.Size = new System.Drawing.Size(939, 356);
            this.dataGridView_playerManage.TabIndex = 9;
            // 
            // Player_ID
            // 
            this.Player_ID.HeaderText = "球员编号";
            this.Player_ID.Name = "Player_ID";
            this.Player_ID.ReadOnly = true;
            this.Player_ID.Visible = false;
            // 
            // player_Name
            // 
            this.player_Name.HeaderText = "球员姓名";
            this.player_Name.Name = "player_Name";
            this.player_Name.ReadOnly = true;
            // 
            // player_Number
            // 
            this.player_Number.HeaderText = "球员号码";
            this.player_Number.Name = "player_Number";
            this.player_Number.ReadOnly = true;
            // 
            // player_Position
            // 
            this.player_Position.HeaderText = "球员位置";
            this.player_Position.Name = "player_Position";
            this.player_Position.ReadOnly = true;
            // 
            // player_Team
            // 
            this.player_Team.HeaderText = "所属球队";
            this.player_Team.Name = "player_Team";
            this.player_Team.ReadOnly = true;
            // 
            // playerIDnum
            // 
            this.playerIDnum.HeaderText = "身份证号";
            this.playerIDnum.Name = "playerIDnum";
            this.playerIDnum.ReadOnly = true;
            // 
            // groupBox_playerManage
            // 
            this.groupBox_playerManage.Controls.Add(this.label2);
            this.groupBox_playerManage.Controls.Add(this.linkLabel_PlayerExcelImport);
            this.groupBox_playerManage.Controls.Add(this.cancel);
            this.groupBox_playerManage.Controls.Add(this.delete);
            this.groupBox_playerManage.Controls.Add(this.alter);
            this.groupBox_playerManage.Controls.Add(this.createNew);
            this.groupBox_playerManage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_playerManage.Location = new System.Drawing.Point(0, 356);
            this.groupBox_playerManage.Name = "groupBox_playerManage";
            this.groupBox_playerManage.Size = new System.Drawing.Size(939, 116);
            this.groupBox_playerManage.TabIndex = 11;
            this.groupBox_playerManage.TabStop = false;
            this.groupBox_playerManage.Text = "操作";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "太慢？请批量！";
            // 
            // linkLabel_PlayerExcelImport
            // 
            this.linkLabel_PlayerExcelImport.AutoSize = true;
            this.linkLabel_PlayerExcelImport.Location = new System.Drawing.Point(132, 50);
            this.linkLabel_PlayerExcelImport.Name = "linkLabel_PlayerExcelImport";
            this.linkLabel_PlayerExcelImport.Size = new System.Drawing.Size(104, 16);
            this.linkLabel_PlayerExcelImport.TabIndex = 11;
            this.linkLabel_PlayerExcelImport.TabStop = true;
            this.linkLabel_PlayerExcelImport.Text = "批量导入球员";
            this.linkLabel_PlayerExcelImport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_PlayerExcelImport_LinkClicked);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(784, 40);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(80, 33);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "关闭";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(649, 40);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(80, 33);
            this.delete.TabIndex = 7;
            this.delete.Text = "删除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // alter
            // 
            this.alter.Location = new System.Drawing.Point(511, 40);
            this.alter.Name = "alter";
            this.alter.Size = new System.Drawing.Size(80, 33);
            this.alter.TabIndex = 8;
            this.alter.Text = "修改";
            this.alter.UseVisualStyleBackColor = true;
            this.alter.Click += new System.EventHandler(this.alter_Click);
            // 
            // createNew
            // 
            this.createNew.Location = new System.Drawing.Point(382, 40);
            this.createNew.Name = "createNew";
            this.createNew.Size = new System.Drawing.Size(80, 33);
            this.createNew.TabIndex = 6;
            this.createNew.Text = "新建";
            this.createNew.UseVisualStyleBackColor = true;
            this.createNew.Click += new System.EventHandler(this.createNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "赛事球队";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label_teamName);
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer3.Size = new System.Drawing.Size(1159, 527);
            this.splitContainer3.SplitterDistance = 51;
            this.splitContainer3.TabIndex = 1;
            // 
            // label_teamName
            // 
            this.label_teamName.AutoSize = true;
            this.label_teamName.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_teamName.Location = new System.Drawing.Point(598, 5);
            this.label_teamName.Name = "label_teamName";
            this.label_teamName.Size = new System.Drawing.Size(129, 29);
            this.label_teamName.TabIndex = 1;
            this.label_teamName.Text = "球队名称";
            // 
            // playerManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1159, 527);
            this.Controls.Add(this.splitContainer3);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "playerManage";
            this.Text = "球员管理";
            this.Load += new System.EventHandler(this.playerManage_Load);
            this.Shown += new System.EventHandler(this.playerManage_Shown);
            this.Resize += new System.EventHandler(this.playerManage_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_playerManage)).EndInit();
            this.groupBox_playerManage.ResumeLayout(false);
            this.groupBox_playerManage.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView_playerManage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_Team;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIDnum;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button createNew;
        private System.Windows.Forms.Button alter;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.GroupBox groupBox_playerManage;
        private System.Windows.Forms.ListBox listBox_TeamList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label_teamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel_PlayerExcelImport;

    }
}