namespace FootballMatch.Umasou.Business
{
    partial class OpenMatch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_match = new System.Windows.Forms.DataGridView();
            this.match_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.switch_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox_MatchDescription = new System.Windows.Forms.GroupBox();
            this.richTextBox_MatchDescription = new System.Windows.Forms.RichTextBox();
            this.groupBox_Name = new System.Windows.Forms.GroupBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.groupBox_SeasonDescription = new System.Windows.Forms.GroupBox();
            this.richTextBox_SeasonDescription = new System.Windows.Forms.RichTextBox();
            this.listBox_Seasons = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_match)).BeginInit();
            this.groupBox_MatchDescription.SuspendLayout();
            this.groupBox_Name.SuspendLayout();
            this.groupBox_SeasonDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_match
            // 
            this.dataGridView_match.AllowUserToAddRows = false;
            this.dataGridView_match.AllowUserToDeleteRows = false;
            this.dataGridView_match.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_match.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_match.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_match.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_match.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.match_ID,
            this.matchName,
            this.matchDescription,
            this.switch_Num,
            this.serialNum});
            this.dataGridView_match.Location = new System.Drawing.Point(12, 10);
            this.dataGridView_match.MultiSelect = false;
            this.dataGridView_match.Name = "dataGridView_match";
            this.dataGridView_match.ReadOnly = true;
            this.dataGridView_match.RowTemplate.Height = 23;
            this.dataGridView_match.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_match.Size = new System.Drawing.Size(443, 191);
            this.dataGridView_match.TabIndex = 0;
            this.dataGridView_match.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_match_CellClick);
            this.dataGridView_match.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_match_CellDoubleClick);
            this.dataGridView_match.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_match_RowPostPaint);
            // 
            // match_ID
            // 
            this.match_ID.HeaderText = "赛事编号";
            this.match_ID.Name = "match_ID";
            this.match_ID.ReadOnly = true;
            this.match_ID.Visible = false;
            // 
            // matchName
            // 
            this.matchName.HeaderText = "赛事名称";
            this.matchName.Name = "matchName";
            this.matchName.ReadOnly = true;
            // 
            // matchDescription
            // 
            this.matchDescription.HeaderText = "赛事描述";
            this.matchDescription.Name = "matchDescription";
            this.matchDescription.ReadOnly = true;
            this.matchDescription.Visible = false;
            // 
            // switch_Num
            // 
            this.switch_Num.HeaderText = "黄转红数量";
            this.switch_Num.Name = "switch_Num";
            this.switch_Num.ReadOnly = true;
            // 
            // serialNum
            // 
            this.serialNum.HeaderText = "比赛数量";
            this.serialNum.Name = "serialNum";
            this.serialNum.ReadOnly = true;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(484, 318);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(80, 30);
            this.OK.TabIndex = 1;
            this.OK.Text = "确定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(604, 318);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(80, 30);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // groupBox_MatchDescription
            // 
            this.groupBox_MatchDescription.Controls.Add(this.richTextBox_MatchDescription);
            this.groupBox_MatchDescription.Location = new System.Drawing.Point(12, 207);
            this.groupBox_MatchDescription.Name = "groupBox_MatchDescription";
            this.groupBox_MatchDescription.Size = new System.Drawing.Size(443, 100);
            this.groupBox_MatchDescription.TabIndex = 3;
            this.groupBox_MatchDescription.TabStop = false;
            this.groupBox_MatchDescription.Text = "赛事描述";
            // 
            // richTextBox_MatchDescription
            // 
            this.richTextBox_MatchDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_MatchDescription.Location = new System.Drawing.Point(3, 22);
            this.richTextBox_MatchDescription.Name = "richTextBox_MatchDescription";
            this.richTextBox_MatchDescription.ReadOnly = true;
            this.richTextBox_MatchDescription.Size = new System.Drawing.Size(437, 75);
            this.richTextBox_MatchDescription.TabIndex = 0;
            this.richTextBox_MatchDescription.Text = "";
            // 
            // groupBox_Name
            // 
            this.groupBox_Name.Controls.Add(this.textBox_Name);
            this.groupBox_Name.Location = new System.Drawing.Point(461, 10);
            this.groupBox_Name.Name = "groupBox_Name";
            this.groupBox_Name.Size = new System.Drawing.Size(248, 56);
            this.groupBox_Name.TabIndex = 4;
            this.groupBox_Name.TabStop = false;
            this.groupBox_Name.Text = "赛事名称";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Name.Location = new System.Drawing.Point(3, 22);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.ReadOnly = true;
            this.textBox_Name.Size = new System.Drawing.Size(242, 26);
            this.textBox_Name.TabIndex = 0;
            // 
            // groupBox_SeasonDescription
            // 
            this.groupBox_SeasonDescription.BackColor = System.Drawing.Color.White;
            this.groupBox_SeasonDescription.Controls.Add(this.richTextBox_SeasonDescription);
            this.groupBox_SeasonDescription.Location = new System.Drawing.Point(464, 207);
            this.groupBox_SeasonDescription.Name = "groupBox_SeasonDescription";
            this.groupBox_SeasonDescription.Size = new System.Drawing.Size(245, 103);
            this.groupBox_SeasonDescription.TabIndex = 5;
            this.groupBox_SeasonDescription.TabStop = false;
            this.groupBox_SeasonDescription.Text = "赛季描述";
            // 
            // richTextBox_SeasonDescription
            // 
            this.richTextBox_SeasonDescription.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_SeasonDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_SeasonDescription.Location = new System.Drawing.Point(3, 22);
            this.richTextBox_SeasonDescription.Name = "richTextBox_SeasonDescription";
            this.richTextBox_SeasonDescription.Size = new System.Drawing.Size(239, 78);
            this.richTextBox_SeasonDescription.TabIndex = 0;
            this.richTextBox_SeasonDescription.Text = "";
            // 
            // listBox_Seasons
            // 
            this.listBox_Seasons.FormattingEnabled = true;
            this.listBox_Seasons.ItemHeight = 16;
            this.listBox_Seasons.Location = new System.Drawing.Point(467, 85);
            this.listBox_Seasons.Name = "listBox_Seasons";
            this.listBox_Seasons.Size = new System.Drawing.Size(239, 116);
            this.listBox_Seasons.TabIndex = 6;
            this.listBox_Seasons.SelectedIndexChanged += new System.EventHandler(this.listBox_Seasons_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "选择赛季";
            // 
            // OpenMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Seasons);
            this.Controls.Add(this.groupBox_SeasonDescription);
            this.Controls.Add(this.groupBox_Name);
            this.Controls.Add(this.groupBox_MatchDescription);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.dataGridView_match);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "OpenMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打开赛季";
            this.Shown += new System.EventHandler(this.OpenMatch_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_match)).EndInit();
            this.groupBox_MatchDescription.ResumeLayout(false);
            this.groupBox_Name.ResumeLayout(false);
            this.groupBox_Name.PerformLayout();
            this.groupBox_SeasonDescription.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_match;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox groupBox_MatchDescription;
        private System.Windows.Forms.RichTextBox richTextBox_MatchDescription;
        private System.Windows.Forms.GroupBox groupBox_Name;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn match_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn switch_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNum;
        private System.Windows.Forms.GroupBox groupBox_SeasonDescription;
        private System.Windows.Forms.RichTextBox richTextBox_SeasonDescription;
        private System.Windows.Forms.ListBox listBox_Seasons;
        private System.Windows.Forms.Label label1;
    }
}