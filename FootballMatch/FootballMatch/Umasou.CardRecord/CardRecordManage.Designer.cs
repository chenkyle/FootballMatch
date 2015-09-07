namespace FootballMatch.Umasou.CardRecord
{
    partial class CardRecordManage
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
            this.card_UniqueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.card_matchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.card_MatchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.card_playerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.card_playerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.card_YellowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.card_redNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.card_GameNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.card_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.card_UniqueID,
            this.card_matchID,
            this.card_MatchName,
            this.card_playerID,
            this.card_playerName,
            this.card_YellowNum,
            this.card_redNum,
            this.card_GameNum,
            this.card_date});
            this.dataGridView_gameInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_gameInfo.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_gameInfo.MultiSelect = false;
            this.dataGridView_gameInfo.Name = "dataGridView_gameInfo";
            this.dataGridView_gameInfo.ReadOnly = true;
            this.dataGridView_gameInfo.RowTemplate.Height = 23;
            this.dataGridView_gameInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_gameInfo.Size = new System.Drawing.Size(785, 358);
            this.dataGridView_gameInfo.TabIndex = 2;
            this.dataGridView_gameInfo.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_gameInfo_RowPostPaint);
            // 
            // card_UniqueID
            // 
            this.card_UniqueID.HeaderText = "唯一标识号";
            this.card_UniqueID.Name = "card_UniqueID";
            this.card_UniqueID.ReadOnly = true;
            this.card_UniqueID.Visible = false;
            // 
            // card_matchID
            // 
            this.card_matchID.HeaderText = "赛事编号";
            this.card_matchID.Name = "card_matchID";
            this.card_matchID.ReadOnly = true;
            this.card_matchID.Visible = false;
            // 
            // card_MatchName
            // 
            this.card_MatchName.HeaderText = "赛事名称";
            this.card_MatchName.Name = "card_MatchName";
            this.card_MatchName.ReadOnly = true;
            // 
            // card_playerID
            // 
            this.card_playerID.HeaderText = "球员编号";
            this.card_playerID.Name = "card_playerID";
            this.card_playerID.ReadOnly = true;
            this.card_playerID.Visible = false;
            // 
            // card_playerName
            // 
            this.card_playerName.HeaderText = "球员姓名";
            this.card_playerName.Name = "card_playerName";
            this.card_playerName.ReadOnly = true;
            // 
            // card_YellowNum
            // 
            this.card_YellowNum.HeaderText = "黄牌数量";
            this.card_YellowNum.Name = "card_YellowNum";
            this.card_YellowNum.ReadOnly = true;
            // 
            // card_redNum
            // 
            this.card_redNum.HeaderText = "红牌数量";
            this.card_redNum.Name = "card_redNum";
            this.card_redNum.ReadOnly = true;
            // 
            // card_GameNum
            // 
            this.card_GameNum.HeaderText = "比赛序号";
            this.card_GameNum.Name = "card_GameNum";
            this.card_GameNum.ReadOnly = true;
            // 
            // card_date
            // 
            this.card_date.HeaderText = "罚牌日期";
            this.card_date.Name = "card_date";
            this.card_date.ReadOnly = true;
            this.card_date.Visible = false;
            // 
            // CardRecordManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 358);
            this.Controls.Add(this.dataGridView_gameInfo);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CardRecordManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "罚牌总览";
            this.Shown += new System.EventHandler(this.CardRecordManage_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_gameInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_gameInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn card_UniqueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn card_matchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn card_MatchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn card_playerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn card_playerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn card_YellowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn card_redNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn card_GameNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn card_date;
    }
}