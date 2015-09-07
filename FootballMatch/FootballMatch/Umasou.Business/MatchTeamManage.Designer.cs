namespace FootballMatch.Umasou.Business
{
    partial class MatchTeamManage
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
            this.dataGridView_NotAssiagnedTeam = new System.Windows.Forms.DataGridView();
            this.team_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team_Leader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team_Coach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_assignedTeam = new System.Windows.Forms.DataGridView();
            this._teamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._teamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._teamLeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._teamManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._teamCoach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_addAll = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_removeAll = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.groupBox_notAssiagned = new System.Windows.Forms.GroupBox();
            this.groupBox_assiagned = new System.Windows.Forms.GroupBox();
            this.groupBox_button = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NotAssiagnedTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_assignedTeam)).BeginInit();
            this.groupBox_notAssiagned.SuspendLayout();
            this.groupBox_assiagned.SuspendLayout();
            this.groupBox_button.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_NotAssiagnedTeam
            // 
            this.dataGridView_NotAssiagnedTeam.AllowUserToAddRows = false;
            this.dataGridView_NotAssiagnedTeam.AllowUserToDeleteRows = false;
            this.dataGridView_NotAssiagnedTeam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_NotAssiagnedTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NotAssiagnedTeam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.team_ID,
            this.team_Name,
            this.team_Leader,
            this.team_Manager,
            this.team_Coach});
            this.dataGridView_NotAssiagnedTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_NotAssiagnedTeam.Location = new System.Drawing.Point(3, 22);
            this.dataGridView_NotAssiagnedTeam.Name = "dataGridView_NotAssiagnedTeam";
            this.dataGridView_NotAssiagnedTeam.ReadOnly = true;
            this.dataGridView_NotAssiagnedTeam.RowTemplate.Height = 23;
            this.dataGridView_NotAssiagnedTeam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_NotAssiagnedTeam.Size = new System.Drawing.Size(374, 255);
            this.dataGridView_NotAssiagnedTeam.TabIndex = 1;
            this.dataGridView_NotAssiagnedTeam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_NotAssiagnedTeam_CellClick);
            this.dataGridView_NotAssiagnedTeam.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_NotAssiagnedTeam_RowPostPaint);
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
            // team_Leader
            // 
            this.team_Leader.HeaderText = "球队队长";
            this.team_Leader.Name = "team_Leader";
            this.team_Leader.ReadOnly = true;
            // 
            // team_Manager
            // 
            this.team_Manager.HeaderText = "球队经理";
            this.team_Manager.Name = "team_Manager";
            this.team_Manager.ReadOnly = true;
            this.team_Manager.Visible = false;
            // 
            // team_Coach
            // 
            this.team_Coach.HeaderText = "球队主教练";
            this.team_Coach.Name = "team_Coach";
            this.team_Coach.ReadOnly = true;
            // 
            // dataGridView_assignedTeam
            // 
            this.dataGridView_assignedTeam.AllowUserToAddRows = false;
            this.dataGridView_assignedTeam.AllowUserToDeleteRows = false;
            this.dataGridView_assignedTeam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_assignedTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_assignedTeam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._teamID,
            this._teamName,
            this._teamLeader,
            this._teamManager,
            this._teamCoach});
            this.dataGridView_assignedTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_assignedTeam.Location = new System.Drawing.Point(3, 22);
            this.dataGridView_assignedTeam.Name = "dataGridView_assignedTeam";
            this.dataGridView_assignedTeam.ReadOnly = true;
            this.dataGridView_assignedTeam.RowTemplate.Height = 23;
            this.dataGridView_assignedTeam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_assignedTeam.Size = new System.Drawing.Size(374, 255);
            this.dataGridView_assignedTeam.TabIndex = 2;
            this.dataGridView_assignedTeam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_assignedTeam_CellClick);
            this.dataGridView_assignedTeam.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_assignedTeam_RowPostPaint);
            // 
            // _teamID
            // 
            this._teamID.HeaderText = "球队编号";
            this._teamID.Name = "_teamID";
            this._teamID.ReadOnly = true;
            this._teamID.Visible = false;
            // 
            // _teamName
            // 
            this._teamName.HeaderText = "球队名称";
            this._teamName.Name = "_teamName";
            this._teamName.ReadOnly = true;
            // 
            // _teamLeader
            // 
            this._teamLeader.HeaderText = "球队队长";
            this._teamLeader.Name = "_teamLeader";
            this._teamLeader.ReadOnly = true;
            // 
            // _teamManager
            // 
            this._teamManager.HeaderText = "球队经理";
            this._teamManager.Name = "_teamManager";
            this._teamManager.ReadOnly = true;
            this._teamManager.Visible = false;
            // 
            // _teamCoach
            // 
            this._teamCoach.HeaderText = "球队主教练";
            this._teamCoach.Name = "_teamCoach";
            this._teamCoach.ReadOnly = true;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(18, 25);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(60, 30);
            this.button_Add.TabIndex = 3;
            this.button_Add.Text = ">";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_addAll
            // 
            this.button_addAll.Location = new System.Drawing.Point(18, 70);
            this.button_addAll.Name = "button_addAll";
            this.button_addAll.Size = new System.Drawing.Size(60, 30);
            this.button_addAll.TabIndex = 4;
            this.button_addAll.Text = ">>";
            this.button_addAll.UseVisualStyleBackColor = true;
            this.button_addAll.Click += new System.EventHandler(this.button_addAll_Click);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(18, 116);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(60, 30);
            this.button_remove.TabIndex = 5;
            this.button_remove.Text = "<";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_removeAll
            // 
            this.button_removeAll.Location = new System.Drawing.Point(18, 167);
            this.button_removeAll.Name = "button_removeAll";
            this.button_removeAll.Size = new System.Drawing.Size(60, 30);
            this.button_removeAll.TabIndex = 6;
            this.button_removeAll.Text = "<<";
            this.button_removeAll.UseVisualStyleBackColor = true;
            this.button_removeAll.Click += new System.EventHandler(this.button_removeAll_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(18, 232);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(60, 30);
            this.button_Close.TabIndex = 7;
            this.button_Close.Text = "关闭";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // groupBox_notAssiagned
            // 
            this.groupBox_notAssiagned.Controls.Add(this.dataGridView_NotAssiagnedTeam);
            this.groupBox_notAssiagned.Location = new System.Drawing.Point(12, 14);
            this.groupBox_notAssiagned.Name = "groupBox_notAssiagned";
            this.groupBox_notAssiagned.Size = new System.Drawing.Size(380, 280);
            this.groupBox_notAssiagned.TabIndex = 8;
            this.groupBox_notAssiagned.TabStop = false;
            this.groupBox_notAssiagned.Text = "未分配球队";
            // 
            // groupBox_assiagned
            // 
            this.groupBox_assiagned.Controls.Add(this.dataGridView_assignedTeam);
            this.groupBox_assiagned.Location = new System.Drawing.Point(501, 14);
            this.groupBox_assiagned.Name = "groupBox_assiagned";
            this.groupBox_assiagned.Size = new System.Drawing.Size(380, 280);
            this.groupBox_assiagned.TabIndex = 9;
            this.groupBox_assiagned.TabStop = false;
            this.groupBox_assiagned.Text = "已分配球队";
            // 
            // groupBox_button
            // 
            this.groupBox_button.Controls.Add(this.button_addAll);
            this.groupBox_button.Controls.Add(this.button_Add);
            this.groupBox_button.Controls.Add(this.button_Close);
            this.groupBox_button.Controls.Add(this.button_remove);
            this.groupBox_button.Controls.Add(this.button_removeAll);
            this.groupBox_button.Location = new System.Drawing.Point(398, 14);
            this.groupBox_button.Name = "groupBox_button";
            this.groupBox_button.Size = new System.Drawing.Size(97, 277);
            this.groupBox_button.TabIndex = 10;
            this.groupBox_button.TabStop = false;
            // 
            // MatchTeamManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 310);
            this.Controls.Add(this.groupBox_button);
            this.Controls.Add(this.groupBox_assiagned);
            this.Controls.Add(this.groupBox_notAssiagned);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MatchTeamManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "赛事球队管理";
            this.Load += new System.EventHandler(this.MatchTeamManage_Load);
            this.Shown += new System.EventHandler(this.MatchTeamManage_Shown);
            this.Resize += new System.EventHandler(this.MatchTeamManage_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NotAssiagnedTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_assignedTeam)).EndInit();
            this.groupBox_notAssiagned.ResumeLayout(false);
            this.groupBox_assiagned.ResumeLayout(false);
            this.groupBox_button.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_NotAssiagnedTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn team_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn team_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn team_Leader;
        private System.Windows.Forms.DataGridViewTextBoxColumn team_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn team_Coach;
        private System.Windows.Forms.DataGridView dataGridView_assignedTeam;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_addAll;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_removeAll;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.GroupBox groupBox_notAssiagned;
        private System.Windows.Forms.GroupBox groupBox_assiagned;
        private System.Windows.Forms.GroupBox groupBox_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn _teamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _teamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _teamLeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn _teamManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn _teamCoach;
    }
}