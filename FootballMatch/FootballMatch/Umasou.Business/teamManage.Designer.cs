namespace FootballMatch.Umasou.Business
{
    partial class teamManage
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
            this.dataGridView_teamManage = new System.Windows.Forms.DataGridView();
            this.team_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.introduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team_Leader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team_Coach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createNew = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.alter = new System.Windows.Forms.Button();
            this.groupBox_teamManage = new System.Windows.Forms.GroupBox();
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_teamManage)).BeginInit();
            this.groupBox_teamManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_teamManage
            // 
            this.dataGridView_teamManage.AllowUserToAddRows = false;
            this.dataGridView_teamManage.AllowUserToDeleteRows = false;
            this.dataGridView_teamManage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_teamManage.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_teamManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_teamManage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.team_ID,
            this.team_Name,
            this.teamFullName,
            this.matchName,
            this.location,
            this.birthDate,
            this.introduction,
            this.team_Leader,
            this.team_Manager,
            this.team_Coach});
            this.dataGridView_teamManage.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_teamManage.Name = "dataGridView_teamManage";
            this.dataGridView_teamManage.ReadOnly = true;
            this.dataGridView_teamManage.RowTemplate.Height = 23;
            this.dataGridView_teamManage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_teamManage.Size = new System.Drawing.Size(620, 267);
            this.dataGridView_teamManage.TabIndex = 0;
            this.dataGridView_teamManage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_teamManage_CellClick);
            this.dataGridView_teamManage.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_teamManage_RowPostPaint);
            // 
            // team_ID
            // 
            this.team_ID.HeaderText = "球队编号";
            this.team_ID.Name = "team_ID";
            this.team_ID.ReadOnly = true;
            this.team_ID.Visible = false;
            // 
            // team_Name
            // 
            this.team_Name.HeaderText = "球队名称";
            this.team_Name.Name = "team_Name";
            this.team_Name.ReadOnly = true;
            // 
            // teamFullName
            // 
            this.teamFullName.HeaderText = "球队全称";
            this.teamFullName.Name = "teamFullName";
            this.teamFullName.ReadOnly = true;
            // 
            // matchName
            // 
            this.matchName.HeaderText = "所属联赛名称";
            this.matchName.Name = "matchName";
            this.matchName.ReadOnly = true;
            // 
            // location
            // 
            this.location.HeaderText = "球队所在城市/位置";
            this.location.Name = "location";
            this.location.ReadOnly = true;
            // 
            // birthDate
            // 
            this.birthDate.HeaderText = "球队创建日期";
            this.birthDate.Name = "birthDate";
            this.birthDate.ReadOnly = true;
            // 
            // introduction
            // 
            this.introduction.HeaderText = "球队简介";
            this.introduction.Name = "introduction";
            this.introduction.ReadOnly = true;
            // 
            // team_Leader
            // 
            this.team_Leader.HeaderText = "球队队长";
            this.team_Leader.Name = "team_Leader";
            this.team_Leader.ReadOnly = true;
            // 
            // team_Manager
            // 
            this.team_Manager.HeaderText = "球队总经理";
            this.team_Manager.Name = "team_Manager";
            this.team_Manager.ReadOnly = true;
            // 
            // team_Coach
            // 
            this.team_Coach.HeaderText = "球队主教练";
            this.team_Coach.Name = "team_Coach";
            this.team_Coach.ReadOnly = true;
            // 
            // createNew
            // 
            this.createNew.Location = new System.Drawing.Point(6, 15);
            this.createNew.Name = "createNew";
            this.createNew.Size = new System.Drawing.Size(80, 30);
            this.createNew.TabIndex = 1;
            this.createNew.Text = "新建";
            this.createNew.UseVisualStyleBackColor = true;
            this.createNew.Click += new System.EventHandler(this.createNew_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(232, 15);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(80, 30);
            this.delete.TabIndex = 2;
            this.delete.Text = "删除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // alter
            // 
            this.alter.Location = new System.Drawing.Point(118, 15);
            this.alter.Name = "alter";
            this.alter.Size = new System.Drawing.Size(80, 30);
            this.alter.TabIndex = 3;
            this.alter.Text = "修改";
            this.alter.UseVisualStyleBackColor = true;
            this.alter.Click += new System.EventHandler(this.alter_Click);
            // 
            // groupBox_teamManage
            // 
            this.groupBox_teamManage.Controls.Add(this.cancel);
            this.groupBox_teamManage.Controls.Add(this.createNew);
            this.groupBox_teamManage.Controls.Add(this.alter);
            this.groupBox_teamManage.Controls.Add(this.delete);
            this.groupBox_teamManage.Location = new System.Drawing.Point(208, 285);
            this.groupBox_teamManage.Name = "groupBox_teamManage";
            this.groupBox_teamManage.Size = new System.Drawing.Size(424, 51);
            this.groupBox_teamManage.TabIndex = 4;
            this.groupBox_teamManage.TabStop = false;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(338, 15);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(80, 30);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "关闭";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // teamManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 346);
            this.Controls.Add(this.groupBox_teamManage);
            this.Controls.Add(this.dataGridView_teamManage);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "teamManage";
            this.Text = "球队管理";
            this.Load += new System.EventHandler(this.teamManage_Load);
            this.Shown += new System.EventHandler(this.teamManage_Shown);
            this.Resize += new System.EventHandler(this.teamManage_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_teamManage)).EndInit();
            this.groupBox_teamManage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_teamManage;
        private System.Windows.Forms.Button createNew;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button alter;
        private System.Windows.Forms.GroupBox groupBox_teamManage;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn team_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn team_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn introduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn team_Leader;
        private System.Windows.Forms.DataGridViewTextBoxColumn team_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn team_Coach;
    }
}