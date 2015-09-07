namespace FootballMatch.Umasou.Business
{
    partial class MatchPlayerManage
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
            this.button_addAll = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.groupBox_assiagned = new System.Windows.Forms.GroupBox();
            this.button_removeAll = new System.Windows.Forms.Button();
            this.groupBox_notAssiagned = new System.Windows.Forms.GroupBox();
            this.groupBox_button = new System.Windows.Forms.GroupBox();
            this.dataGridView_notAssignedPlayer = new System.Windows.Forms.DataGridView();
            this.dataGridView_assignedPlayer = new System.Windows.Forms.DataGridView();
            this._player_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._player_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._player_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._player_Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._player_Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_assiagned.SuspendLayout();
            this.groupBox_notAssiagned.SuspendLayout();
            this.groupBox_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_notAssignedPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_assignedPlayer)).BeginInit();
            this.SuspendLayout();
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
            // groupBox_assiagned
            // 
            this.groupBox_assiagned.Controls.Add(this.dataGridView_assignedPlayer);
            this.groupBox_assiagned.Location = new System.Drawing.Point(501, 15);
            this.groupBox_assiagned.Name = "groupBox_assiagned";
            this.groupBox_assiagned.Size = new System.Drawing.Size(389, 277);
            this.groupBox_assiagned.TabIndex = 12;
            this.groupBox_assiagned.TabStop = false;
            this.groupBox_assiagned.Text = "已分配球员";
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
            // groupBox_notAssiagned
            // 
            this.groupBox_notAssiagned.Controls.Add(this.dataGridView_notAssignedPlayer);
            this.groupBox_notAssiagned.Location = new System.Drawing.Point(5, 15);
            this.groupBox_notAssiagned.Name = "groupBox_notAssiagned";
            this.groupBox_notAssiagned.Size = new System.Drawing.Size(387, 280);
            this.groupBox_notAssiagned.TabIndex = 11;
            this.groupBox_notAssiagned.TabStop = false;
            this.groupBox_notAssiagned.Text = "未分配球员";
            // 
            // groupBox_button
            // 
            this.groupBox_button.Controls.Add(this.button_addAll);
            this.groupBox_button.Controls.Add(this.button_Add);
            this.groupBox_button.Controls.Add(this.button_Close);
            this.groupBox_button.Controls.Add(this.button_remove);
            this.groupBox_button.Controls.Add(this.button_removeAll);
            this.groupBox_button.Location = new System.Drawing.Point(398, 15);
            this.groupBox_button.Name = "groupBox_button";
            this.groupBox_button.Size = new System.Drawing.Size(97, 277);
            this.groupBox_button.TabIndex = 13;
            this.groupBox_button.TabStop = false;
            // 
            // dataGridView_notAssignedPlayer
            // 
            this.dataGridView_notAssignedPlayer.AllowUserToAddRows = false;
            this.dataGridView_notAssignedPlayer.AllowUserToDeleteRows = false;
            this.dataGridView_notAssignedPlayer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_notAssignedPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_notAssignedPlayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Player_ID,
            this.player_Name,
            this.player_Number,
            this.player_Position,
            this.player_Team});
            this.dataGridView_notAssignedPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_notAssignedPlayer.Location = new System.Drawing.Point(3, 22);
            this.dataGridView_notAssignedPlayer.Name = "dataGridView_notAssignedPlayer";
            this.dataGridView_notAssignedPlayer.ReadOnly = true;
            this.dataGridView_notAssignedPlayer.RowTemplate.Height = 23;
            this.dataGridView_notAssignedPlayer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_notAssignedPlayer.Size = new System.Drawing.Size(381, 255);
            this.dataGridView_notAssignedPlayer.TabIndex = 6;
            this.dataGridView_notAssignedPlayer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_notAssignedPlayer_CellClick);
            this.dataGridView_notAssignedPlayer.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_notAssignedPlayer_RowPostPaint);
            // 
            // dataGridView_assignedPlayer
            // 
            this.dataGridView_assignedPlayer.AllowUserToAddRows = false;
            this.dataGridView_assignedPlayer.AllowUserToDeleteRows = false;
            this.dataGridView_assignedPlayer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_assignedPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_assignedPlayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._player_ID,
            this._player_Name,
            this._player_Num,
            this._player_Position,
            this._player_Team});
            this.dataGridView_assignedPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_assignedPlayer.Location = new System.Drawing.Point(3, 22);
            this.dataGridView_assignedPlayer.Name = "dataGridView_assignedPlayer";
            this.dataGridView_assignedPlayer.ReadOnly = true;
            this.dataGridView_assignedPlayer.RowTemplate.Height = 23;
            this.dataGridView_assignedPlayer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_assignedPlayer.Size = new System.Drawing.Size(383, 252);
            this.dataGridView_assignedPlayer.TabIndex = 7;
            this.dataGridView_assignedPlayer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_assignedPlayer_CellClick);
            this.dataGridView_assignedPlayer.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_assignedPlayer_RowPostPaint);
            // 
            // _player_ID
            // 
            this._player_ID.HeaderText = "球员编号";
            this._player_ID.Name = "_player_ID";
            this._player_ID.ReadOnly = true;
            this._player_ID.Visible = false;
            // 
            // _player_Name
            // 
            this._player_Name.HeaderText = "球员姓名";
            this._player_Name.Name = "_player_Name";
            this._player_Name.ReadOnly = true;
            // 
            // _player_Num
            // 
            this._player_Num.HeaderText = "球员号码";
            this._player_Num.Name = "_player_Num";
            this._player_Num.ReadOnly = true;
            // 
            // _player_Position
            // 
            this._player_Position.HeaderText = "球员位置";
            this._player_Position.Name = "_player_Position";
            this._player_Position.ReadOnly = true;
            // 
            // _player_Team
            // 
            this._player_Team.HeaderText = "所属球队";
            this._player_Team.Name = "_player_Team";
            this._player_Team.ReadOnly = true;
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
            // MatchPlayerManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 310);
            this.Controls.Add(this.groupBox_assiagned);
            this.Controls.Add(this.groupBox_notAssiagned);
            this.Controls.Add(this.groupBox_button);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MatchPlayerManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "赛事球员管理";
            this.Load += new System.EventHandler(this.MatchPlayerManage_Load);
            this.Shown += new System.EventHandler(this.MatchPlayerManage_Shown);
            this.Resize += new System.EventHandler(this.MatchPlayerManage_Resize);
            this.groupBox_assiagned.ResumeLayout(false);
            this.groupBox_notAssiagned.ResumeLayout(false);
            this.groupBox_button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_notAssignedPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_assignedPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_addAll;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.GroupBox groupBox_assiagned;
        private System.Windows.Forms.Button button_removeAll;
        private System.Windows.Forms.GroupBox groupBox_notAssiagned;
        private System.Windows.Forms.GroupBox groupBox_button;
        private System.Windows.Forms.DataGridView dataGridView_notAssignedPlayer;
        private System.Windows.Forms.DataGridView dataGridView_assignedPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn _player_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _player_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _player_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn _player_Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn _player_Team;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_Team;
    }
}