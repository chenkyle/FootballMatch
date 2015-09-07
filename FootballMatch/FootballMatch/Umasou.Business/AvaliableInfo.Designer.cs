namespace FootballMatch.Umasou.Business
{
    partial class AvaliableInfo
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
            this.groupBox_gameList = new System.Windows.Forms.GroupBox();
            this.groupBox_avaliableInfo = new System.Windows.Forms.GroupBox();
            this.dataGridView_playerManage = new System.Windows.Forms.DataGridView();
            this.Player_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._leftYellowCardNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_gameInfo)).BeginInit();
            this.groupBox_gameList.SuspendLayout();
            this.groupBox_avaliableInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_playerManage)).BeginInit();
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
            this.dataGridView_gameInfo.Location = new System.Drawing.Point(3, 22);
            this.dataGridView_gameInfo.MultiSelect = false;
            this.dataGridView_gameInfo.Name = "dataGridView_gameInfo";
            this.dataGridView_gameInfo.ReadOnly = true;
            this.dataGridView_gameInfo.RowTemplate.Height = 23;
            this.dataGridView_gameInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_gameInfo.Size = new System.Drawing.Size(350, 338);
            this.dataGridView_gameInfo.TabIndex = 2;
            this.dataGridView_gameInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_gameInfo_CellClick);
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
            this.game_HomeTeam.Visible = false;
            // 
            // game_GuestTeam
            // 
            this.game_GuestTeam.HeaderText = "客队";
            this.game_GuestTeam.Name = "game_GuestTeam";
            this.game_GuestTeam.ReadOnly = true;
            this.game_GuestTeam.Visible = false;
            // 
            // game_Winner
            // 
            this.game_Winner.HeaderText = "获胜队伍";
            this.game_Winner.Name = "game_Winner";
            this.game_Winner.ReadOnly = true;
            this.game_Winner.Visible = false;
            // 
            // game_Result
            // 
            this.game_Result.HeaderText = "比赛结果";
            this.game_Result.Name = "game_Result";
            this.game_Result.ReadOnly = true;
            this.game_Result.Visible = false;
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
            // groupBox_gameList
            // 
            this.groupBox_gameList.Controls.Add(this.dataGridView_gameInfo);
            this.groupBox_gameList.Location = new System.Drawing.Point(12, 12);
            this.groupBox_gameList.Name = "groupBox_gameList";
            this.groupBox_gameList.Size = new System.Drawing.Size(356, 363);
            this.groupBox_gameList.TabIndex = 3;
            this.groupBox_gameList.TabStop = false;
            this.groupBox_gameList.Text = "选择比赛";
            // 
            // groupBox_avaliableInfo
            // 
            this.groupBox_avaliableInfo.Controls.Add(this.dataGridView_playerManage);
            this.groupBox_avaliableInfo.Location = new System.Drawing.Point(390, 12);
            this.groupBox_avaliableInfo.Name = "groupBox_avaliableInfo";
            this.groupBox_avaliableInfo.Size = new System.Drawing.Size(624, 363);
            this.groupBox_avaliableInfo.TabIndex = 4;
            this.groupBox_avaliableInfo.TabStop = false;
            this.groupBox_avaliableInfo.Text = "球员信息";
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
            this.player_Team,
            this.player_State,
            this._leftYellowCardNum});
            this.dataGridView_playerManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_playerManage.Location = new System.Drawing.Point(3, 22);
            this.dataGridView_playerManage.Name = "dataGridView_playerManage";
            this.dataGridView_playerManage.ReadOnly = true;
            this.dataGridView_playerManage.RowTemplate.Height = 23;
            this.dataGridView_playerManage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_playerManage.Size = new System.Drawing.Size(618, 338);
            this.dataGridView_playerManage.TabIndex = 6;
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
            // player_State
            // 
            this.player_State.HeaderText = "状态";
            this.player_State.Name = "player_State";
            this.player_State.ReadOnly = true;
            // 
            // _leftYellowCardNum
            // 
            this._leftYellowCardNum.HeaderText = "余黄牌量";
            this._leftYellowCardNum.Name = "_leftYellowCardNum";
            this._leftYellowCardNum.ReadOnly = true;
            // 
            // AvaliableInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 384);
            this.Controls.Add(this.groupBox_avaliableInfo);
            this.Controls.Add(this.groupBox_gameList);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AvaliableInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "可上场球员信息总览";
            this.Load += new System.EventHandler(this.AvaliableInfo_Load);
            this.Shown += new System.EventHandler(this.AvaliableInfo_Shown);
            this.Resize += new System.EventHandler(this.AvaliableInfo_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_gameInfo)).EndInit();
            this.groupBox_gameList.ResumeLayout(false);
            this.groupBox_avaliableInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_playerManage)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox_gameList;
        private System.Windows.Forms.GroupBox groupBox_avaliableInfo;
        private System.Windows.Forms.DataGridView dataGridView_playerManage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_Team;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_State;
        private System.Windows.Forms.DataGridViewTextBoxColumn _leftYellowCardNum;
    }
}