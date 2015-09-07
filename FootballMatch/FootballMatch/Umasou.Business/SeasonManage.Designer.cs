namespace FootballMatch.Umasou.Business
{
    partial class SeasonManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox_SeasonManage = new System.Windows.Forms.GroupBox();
            this.cancel = new System.Windows.Forms.Button();
            this.createNew = new System.Windows.Forms.Button();
            this.alter = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.dataGridView_seasons = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seasonDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfSeason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_SeasonManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seasons)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_SeasonManage
            // 
            this.groupBox_SeasonManage.Controls.Add(this.cancel);
            this.groupBox_SeasonManage.Controls.Add(this.createNew);
            this.groupBox_SeasonManage.Controls.Add(this.alter);
            this.groupBox_SeasonManage.Controls.Add(this.delete);
            this.groupBox_SeasonManage.Location = new System.Drawing.Point(219, 280);
            this.groupBox_SeasonManage.Name = "groupBox_SeasonManage";
            this.groupBox_SeasonManage.Size = new System.Drawing.Size(424, 51);
            this.groupBox_SeasonManage.TabIndex = 7;
            this.groupBox_SeasonManage.TabStop = false;
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
            // dataGridView_seasons
            // 
            this.dataGridView_seasons.AllowUserToAddRows = false;
            this.dataGridView_seasons.AllowUserToDeleteRows = false;
            this.dataGridView_seasons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_seasons.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_seasons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_seasons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_seasons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.matchName,
            this.seasonDescription,
            this.numOfSeason});
            this.dataGridView_seasons.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_seasons.Name = "dataGridView_seasons";
            this.dataGridView_seasons.ReadOnly = true;
            this.dataGridView_seasons.RowTemplate.Height = 23;
            this.dataGridView_seasons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_seasons.Size = new System.Drawing.Size(620, 261);
            this.dataGridView_seasons.TabIndex = 7;
            this.dataGridView_seasons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_seasons_CellClick);
            this.dataGridView_seasons.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_seasons_RowPostPaint);
            // 
            // id
            // 
            this.id.HeaderText = "赛季编号";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // matchName
            // 
            this.matchName.HeaderText = "赛事名称";
            this.matchName.Name = "matchName";
            this.matchName.ReadOnly = true;
            // 
            // seasonDescription
            // 
            this.seasonDescription.HeaderText = "赛季描述";
            this.seasonDescription.Name = "seasonDescription";
            this.seasonDescription.ReadOnly = true;
            // 
            // numOfSeason
            // 
            this.numOfSeason.HeaderText = "赛季届数";
            this.numOfSeason.Name = "numOfSeason";
            this.numOfSeason.ReadOnly = true;
            // 
            // SeasonManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(652, 337);
            this.Controls.Add(this.dataGridView_seasons);
            this.Controls.Add(this.groupBox_SeasonManage);
            this.Name = "SeasonManage";
            this.Text = "SeasonManage";
            this.Shown += new System.EventHandler(this.SeasonManage_Shown);
            this.Resize += new System.EventHandler(this.SeasonManage_Resize);
            this.groupBox_SeasonManage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seasons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_SeasonManage;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button createNew;
        private System.Windows.Forms.Button alter;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView dataGridView_seasons;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn seasonDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfSeason;

    }
}