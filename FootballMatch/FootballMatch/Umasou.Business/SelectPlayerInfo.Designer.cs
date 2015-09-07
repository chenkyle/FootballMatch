namespace FootballMatch.Umasou.Business
{
    partial class SelectPlayerInfo
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
            this.Player_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_playerManage)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_playerManage
            // 
            this.dataGridView_playerManage.AllowUserToAddRows = false;
            this.dataGridView_playerManage.AllowUserToDeleteRows = false;
            this.dataGridView_playerManage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_playerManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_playerManage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Player_ID,
            this.player_Name,
            this.player_Number,
            this.player_Position,
            this.player_Team});
            this.dataGridView_playerManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_playerManage.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_playerManage.MultiSelect = false;
            this.dataGridView_playerManage.Name = "dataGridView_playerManage";
            this.dataGridView_playerManage.ReadOnly = true;
            this.dataGridView_playerManage.RowTemplate.Height = 23;
            this.dataGridView_playerManage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_playerManage.Size = new System.Drawing.Size(625, 348);
            this.dataGridView_playerManage.TabIndex = 6;
            this.dataGridView_playerManage.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_playerManage_CellDoubleClick);
            this.dataGridView_playerManage.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_playerManage_RowPostPaint);
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
            // SelectPlayerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 348);
            this.Controls.Add(this.dataGridView_playerManage);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SelectPlayerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择球员";
            this.Shown += new System.EventHandler(this.SelectPlayerInfo_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_playerManage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_playerManage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_Team;
    }
}