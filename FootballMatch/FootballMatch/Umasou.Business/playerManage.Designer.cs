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
            this.dataGridView_playerManage = new System.Windows.Forms.DataGridView();
            this.createNew = new System.Windows.Forms.Button();
            this.alter = new System.Windows.Forms.Button();
            this.groupBox_teamManage = new System.Windows.Forms.GroupBox();
            this.cancel = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.Player_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerIDnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_playerManage)).BeginInit();
            this.groupBox_teamManage.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView_playerManage.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_playerManage.Name = "dataGridView_playerManage";
            this.dataGridView_playerManage.ReadOnly = true;
            this.dataGridView_playerManage.RowTemplate.Height = 23;
            this.dataGridView_playerManage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_playerManage.Size = new System.Drawing.Size(620, 267);
            this.dataGridView_playerManage.TabIndex = 5;
            this.dataGridView_playerManage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_teamManage_CellClick);
            this.dataGridView_playerManage.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_teamManage_RowPostPaint);
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
            this.groupBox_teamManage.TabIndex = 6;
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
            // playerManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 346);
            this.Controls.Add(this.dataGridView_playerManage);
            this.Controls.Add(this.groupBox_teamManage);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "playerManage";
            this.Text = "球员管理";
            this.Load += new System.EventHandler(this.playerManage_Load);
            this.Shown += new System.EventHandler(this.playerManage_Shown);
            this.Resize += new System.EventHandler(this.playerManage_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_playerManage)).EndInit();
            this.groupBox_teamManage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_playerManage;
        private System.Windows.Forms.Button createNew;
        private System.Windows.Forms.Button alter;
        private System.Windows.Forms.GroupBox groupBox_teamManage;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_Team;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIDnum;
    }
}