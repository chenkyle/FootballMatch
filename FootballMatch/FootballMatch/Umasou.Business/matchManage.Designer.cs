namespace FootballMatch.Umasou.Business
{
    partial class matchManage
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
            this.createNew = new System.Windows.Forms.Button();
            this.alter = new System.Windows.Forms.Button();
            this.groupBox_teamManage = new System.Windows.Forms.GroupBox();
            this.cancel = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.dataGridView_match = new System.Windows.Forms.DataGridView();
            this.match_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.switch_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serial_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_teamManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_match)).BeginInit();
            this.SuspendLayout();
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
            // dataGridView_match
            // 
            this.dataGridView_match.AllowUserToAddRows = false;
            this.dataGridView_match.AllowUserToDeleteRows = false;
            this.dataGridView_match.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_match.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_match.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_match.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_match.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.match_ID,
            this.matchName,
            this.matchDescription,
            this.switch_Num,
            this.serial_Num});
            this.dataGridView_match.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_match.Name = "dataGridView_match";
            this.dataGridView_match.ReadOnly = true;
            this.dataGridView_match.RowTemplate.Height = 23;
            this.dataGridView_match.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_match.Size = new System.Drawing.Size(620, 261);
            this.dataGridView_match.TabIndex = 7;
            this.dataGridView_match.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_match_CellClick);
            this.dataGridView_match.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_match_RowPostPaint);
            // 
            // match_ID
            // 
            this.match_ID.HeaderText = "赛季编号";
            this.match_ID.Name = "match_ID";
            this.match_ID.ReadOnly = true;
            this.match_ID.Visible = false;
            // 
            // matchName
            // 
            this.matchName.HeaderText = "赛季名称";
            this.matchName.Name = "matchName";
            this.matchName.ReadOnly = true;
            // 
            // matchDescription
            // 
            this.matchDescription.HeaderText = "赛季描述";
            this.matchDescription.Name = "matchDescription";
            this.matchDescription.ReadOnly = true;
            // 
            // switch_Num
            // 
            this.switch_Num.HeaderText = "黄牌转红牌数量";
            this.switch_Num.Name = "switch_Num";
            this.switch_Num.ReadOnly = true;
            // 
            // serial_Num
            // 
            this.serial_Num.HeaderText = "赛事比赛数量";
            this.serial_Num.Name = "serial_Num";
            this.serial_Num.ReadOnly = true;
            // 
            // matchManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 345);
            this.Controls.Add(this.dataGridView_match);
            this.Controls.Add(this.groupBox_teamManage);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "matchManage";
            this.Text = "赛事管理";
            this.Load += new System.EventHandler(this.matchManage_Load);
            this.Shown += new System.EventHandler(this.matchManage_Shown);
            this.Resize += new System.EventHandler(this.matchManage_Resize);
            this.groupBox_teamManage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_match)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createNew;
        private System.Windows.Forms.Button alter;
        private System.Windows.Forms.GroupBox groupBox_teamManage;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView dataGridView_match;
        private System.Windows.Forms.DataGridViewTextBoxColumn match_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn switch_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial_Num;
    }
}