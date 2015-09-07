namespace FootballMatch.Umasou.Business
{
    partial class SelectGameInfo
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
            this.dataGridView_gameInfo = new System.Windows.Forms.DataGridView();
            this.game_UniqueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game_matchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game_HomeTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game_GuestTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game_Winner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game_Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_gameInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_gameInfo
            // 
            this.dataGridView_gameInfo.AllowUserToAddRows = false;
            this.dataGridView_gameInfo.AllowUserToDeleteRows = false;
            this.dataGridView_gameInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_gameInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_gameInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.game_UniqueID,
            this.game_matchID,
            this.game_Name,
            this.game_Num,
            this.game_HomeTeam,
            this.game_GuestTeam,
            this.game_Winner,
            this.game_Result,
            this.game_Address,
            this.game_Date});
            this.dataGridView_gameInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_gameInfo.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_gameInfo.MultiSelect = false;
            this.dataGridView_gameInfo.Name = "dataGridView_gameInfo";
            this.dataGridView_gameInfo.ReadOnly = true;
            this.dataGridView_gameInfo.RowTemplate.Height = 23;
            this.dataGridView_gameInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_gameInfo.Size = new System.Drawing.Size(730, 366);
            this.dataGridView_gameInfo.TabIndex = 0;
            this.dataGridView_gameInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_gameInfo_CellDoubleClick);
            this.dataGridView_gameInfo.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_gameInfo_RowPostPaint);
            // 
            // game_UniqueID
            // 
            this.game_UniqueID.HeaderText = "唯一标识号";
            this.game_UniqueID.Name = "game_UniqueID";
            this.game_UniqueID.ReadOnly = true;
            this.game_UniqueID.Visible = false;
            // 
            // game_matchID
            // 
            this.game_matchID.HeaderText = "赛事编号";
            this.game_matchID.Name = "game_matchID";
            this.game_matchID.ReadOnly = true;
            this.game_matchID.Visible = false;
            // 
            // game_Name
            // 
            this.game_Name.HeaderText = "比赛名称";
            this.game_Name.Name = "game_Name";
            this.game_Name.ReadOnly = true;
            // 
            // game_Num
            // 
            this.game_Num.HeaderText = "比赛序号";
            this.game_Num.Name = "game_Num";
            this.game_Num.ReadOnly = true;
            // 
            // game_HomeTeam
            // 
            this.game_HomeTeam.HeaderText = "主队";
            this.game_HomeTeam.Name = "game_HomeTeam";
            this.game_HomeTeam.ReadOnly = true;
            // 
            // game_GuestTeam
            // 
            this.game_GuestTeam.HeaderText = "客队";
            this.game_GuestTeam.Name = "game_GuestTeam";
            this.game_GuestTeam.ReadOnly = true;
            // 
            // game_Winner
            // 
            this.game_Winner.HeaderText = "获胜队伍";
            this.game_Winner.Name = "game_Winner";
            this.game_Winner.ReadOnly = true;
            // 
            // game_Result
            // 
            this.game_Result.HeaderText = "比赛结果";
            this.game_Result.Name = "game_Result";
            this.game_Result.ReadOnly = true;
            // 
            // game_Address
            // 
            this.game_Address.HeaderText = "比赛地址";
            this.game_Address.Name = "game_Address";
            this.game_Address.ReadOnly = true;
            this.game_Address.Visible = false;
            // 
            // game_Date
            // 
            this.game_Date.HeaderText = "比赛日期";
            this.game_Date.Name = "game_Date";
            this.game_Date.ReadOnly = true;
            this.game_Date.Visible = false;
            // 
            // SelectGameInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 366);
            this.Controls.Add(this.dataGridView_gameInfo);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SelectGameInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择比赛信息";
            this.Shown += new System.EventHandler(this.SelectGameInfo_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_gameInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_gameInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn game_UniqueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn game_matchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn game_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn game_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn game_HomeTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn game_GuestTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn game_Winner;
        private System.Windows.Forms.DataGridViewTextBoxColumn game_Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn game_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn game_Date;
    }
}